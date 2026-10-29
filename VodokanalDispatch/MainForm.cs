using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = Session.FullName + "  •  " + Session.Role;
            cmbStatus.Items.AddRange(new object[] { "Все", "Открытые", "Новая", "В работе", "Выполнена", "Отменена" });
            cmbStatus.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            bool isMaster = Session.Role == "Мастер";
            btnNew.Enabled = !isMaster;
            mnuNewRequest.Enabled = !isMaster;
            mnuDictionaries.Visible = !isMaster;
            mnuReports.Visible = !isMaster;
            mnuUsers.Visible = Session.Role == "Администратор";
            mnuSeparator.Visible = mnuUsers.Visible;

            try
            {
                LoadDistricts();
                LoadRequests();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDistricts()
        {
            DataTable districts = Db.GetTable("SELECT DistrictID, Name FROM Districts ORDER BY Name");
            DataRow all = districts.NewRow();
            all["DistrictID"] = 0;
            all["Name"] = "Все районы";
            districts.Rows.InsertAt(all, 0);
            cmbDistrict.DisplayMember = "Name";
            cmbDistrict.ValueMember = "DistrictID";
            cmbDistrict.DataSource = districts;
        }

        private void LoadRequests()
        {
            string sql = "SELECT RequestID AS [№], CreatedAt AS [Дата приёма], Address AS [Адрес], District AS [Район], " +
                "AccidentType AS [Тип аварии], Priority AS [Приоритет], Status AS [Статус], Brigade AS [Бригада], " +
                "ApplicantName AS [Заявитель], ApplicantPhone AS [Телефон], ClosedAt AS [Выполнена], Overdue " +
                "FROM RequestsView WHERE CreatedAt >= @from AND CreatedAt < @to";
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@from", dtpFrom.Value.Date));
            parameters.Add(new SqlParameter("@to", dtpTo.Value.Date.AddDays(1)));

            if (cmbStatus.Text == "Открытые")
                sql += " AND Status IN (N'Новая', N'В работе')";
            else if (cmbStatus.SelectedIndex > 1)
            {
                sql += " AND Status = @status";
                parameters.Add(new SqlParameter("@status", cmbStatus.Text));
            }

            if (cmbDistrict.SelectedValue != null && (int)cmbDistrict.SelectedValue != 0)
            {
                sql += " AND DistrictID = @district";
                parameters.Add(new SqlParameter("@district", cmbDistrict.SelectedValue));
            }

            if (txtSearch.Text.Trim() != "")
            {
                sql += " AND (Address LIKE @search OR ApplicantName LIKE @search OR ApplicantPhone LIKE @search)";
                parameters.Add(new SqlParameter("@search", "%" + txtSearch.Text.Trim() + "%"));
            }

            if (Session.Role == "Мастер")
            {
                sql += " AND BrigadeID = @brigade";
                parameters.Add(new SqlParameter("@brigade", (object)Session.BrigadeID ?? DBNull.Value));
            }

            sql += " ORDER BY CreatedAt DESC";

            DataTable requests = Db.GetTable(sql, parameters.ToArray());
            dgvRequests.DataSource = requests;
            dgvRequests.Columns["Overdue"].Visible = false;
            dgvRequests.Columns["№"].FillWeight = 40;
            dgvRequests.Columns["Дата приёма"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgvRequests.Columns["Выполнена"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

            int overdue = 0;
            foreach (DataRow row in requests.Rows)
                if ((int)row["Overdue"] == 1)
                    overdue++;
            lblCount.Text = "Заявок: " + requests.Rows.Count + "   Просрочено: " + overdue;
        }

        private void RefreshRequests()
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Начало периода не может быть позже окончания", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                LoadRequests();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenRequest(int requestId)
        {
            using (var form = new RequestForm(requestId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    RefreshRequests();
            }
        }

        private void OpenSelected()
        {
            if (dgvRequests.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку в списке", "Заявки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenRequest(Convert.ToInt32(dgvRequests.CurrentRow.Cells["№"].Value));
        }

        private void dgvRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgvRequests.Rows[e.RowIndex];
            string status = row.Cells["Статус"].Value.ToString();
            if (Convert.ToInt32(row.Cells["Overdue"].Value) == 1)
                e.CellStyle.BackColor = Color.FromArgb(255, 205, 205);
            else if (status == "Новая")
                e.CellStyle.BackColor = Color.FromArgb(255, 246, 200);
            else if (status == "В работе")
                e.CellStyle.BackColor = Color.FromArgb(214, 234, 248);
            else if (status == "Отменена")
                e.CellStyle.ForeColor = Color.Gray;
        }

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenSelected();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            RefreshRequests();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbDistrict.SelectedIndex = 0;
            txtSearch.Clear();
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            RefreshRequests();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenRequest(0);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenSelected();
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            RefreshRequests();
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            CsvExport.Save(dgvRequests, "Заявки АДС");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDictionary(string title, string table, Dictionary<string, string> headers, Dictionary<string, string> lookups)
        {
            using (var form = new DictionaryForm(title, table, headers, lookups))
                form.ShowDialog();
        }

        private void mnuDistricts_Click(object sender, EventArgs e)
        {
            ShowDictionary("Районы города", "Districts",
                new Dictionary<string, string> { { "Name", "Район" } }, null);
            try
            {
                LoadDistricts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки районов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuStreets_Click(object sender, EventArgs e)
        {
            ShowDictionary("Улицы", "Streets",
                new Dictionary<string, string> { { "Name", "Улица" }, { "DistrictID", "Район" } },
                new Dictionary<string, string> { { "DistrictID", "SELECT DistrictID, Name FROM Districts ORDER BY Name" } });
        }

        private void mnuTypes_Click(object sender, EventArgs e)
        {
            ShowDictionary("Типы аварий", "AccidentTypes",
                new Dictionary<string, string> { { "Name", "Тип аварии" }, { "NormHours", "Норматив устранения, ч" } }, null);
        }

        private void mnuBrigades_Click(object sender, EventArgs e)
        {
            ShowDictionary("Бригады", "Brigades",
                new Dictionary<string, string> { { "Name", "Бригада" }, { "Phone", "Телефон" } }, null);
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {
            ShowDictionary("Сотрудники", "Employees",
                new Dictionary<string, string> { { "FullName", "ФИО" }, { "Position", "Должность" }, { "Phone", "Телефон" }, { "BrigadeID", "Бригада" } },
                new Dictionary<string, string> { { "BrigadeID", "SELECT BrigadeID, Name FROM Brigades ORDER BY Name" } });
        }

        private void mnuMaterials_Click(object sender, EventArgs e)
        {
            ShowDictionary("Материалы", "Materials",
                new Dictionary<string, string> { { "Name", "Материал" }, { "Unit", "Ед. изм." }, { "Price", "Цена, руб." } }, null);
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            using (var form = new UsersForm())
                form.ShowDialog();
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {
            using (var form = new ReportsForm())
                form.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИС «Аварийно-диспетчерская служба»\nООО «Водоканал-Сервис», г. Канск\n\n" +
                "Разработал: Демидов Д.Ю., группа ИС.09.24.1\nКГБПОУ «Канский технологический колледж», 2026",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
