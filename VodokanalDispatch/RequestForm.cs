using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class RequestForm : Form
    {
        private int requestId;
        private string oldStatus = "";
        private DateTime? closedAt;
        private DataTable materials;

        public RequestForm(int requestId)
        {
            InitializeComponent();
            this.requestId = requestId;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.AddRange(new object[] { "Аварийная", "Срочная", "Плановая" });
            cmbStatus.Items.AddRange(new object[] { "Новая", "В работе", "Выполнена", "Отменена" });
            try
            {
                LoadLists();
                if (requestId == 0)
                {
                    Text = "Новая заявка";
                    dtpCreated.Value = DateTime.Now;
                    cmbPriority.SelectedItem = "Аварийная";
                    cmbStatus.SelectedItem = "Новая";
                    cmbBrigade.SelectedValue = 0;
                    dtpShutStart.Value = DateTime.Now;
                    dtpShutEnd.Value = DateTime.Now.AddHours(4);
                    lblInfo.Text = "Принял: " + Session.FullName;
                }
                else if (!LoadRequest())
                {
                    MessageBox.Show("Заявка не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }
                LoadMaterials();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            ApplyRole();
            UpdateShutdownControls();
        }

        private void LoadLists()
        {
            DataTable streets = Db.GetTable("SELECT StreetID, Name FROM Streets ORDER BY Name");
            SetList(cmbStreet, streets, "StreetID");
            SetList(cmbShutStreet, streets.Copy(), "StreetID");
            SetList(cmbType, Db.GetTable("SELECT TypeID, Name FROM AccidentTypes ORDER BY Name"), "TypeID");

            DataTable brigades = Db.GetTable("SELECT BrigadeID, Name FROM Brigades ORDER BY Name");
            DataRow none = brigades.NewRow();
            none["BrigadeID"] = 0;
            none["Name"] = "(не назначена)";
            brigades.Rows.InsertAt(none, 0);
            SetList(cmbBrigade, brigades, "BrigadeID");

            cmbMaterial.DisplayMember = "Title";
            cmbMaterial.ValueMember = "MaterialID";
            cmbMaterial.DataSource = Db.GetTable("SELECT MaterialID, Name + N' (' + Unit + N')' AS Title, Name, Unit, Price FROM Materials ORDER BY Name");
        }

        private void SetList(ComboBox combo, DataTable table, string idColumn)
        {
            combo.DisplayMember = "Name";
            combo.ValueMember = idColumn;
            combo.DataSource = table;
        }

        private bool LoadRequest()
        {
            DataTable table = Db.GetTable("SELECT r.*, u.FullName AS Dispatcher FROM Requests r JOIN Users u ON u.UserID = r.DispatcherID WHERE r.RequestID = @id",
                new SqlParameter("@id", requestId));
            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];
            Text = "Заявка № " + requestId;
            dtpCreated.Value = (DateTime)row["CreatedAt"];
            txtApplicant.Text = row["ApplicantName"].ToString();
            txtPhone.Text = row["ApplicantPhone"].ToString();
            cmbStreet.SelectedValue = row["StreetID"];
            txtHouse.Text = row["House"].ToString();
            cmbType.SelectedValue = row["TypeID"];
            cmbPriority.SelectedItem = row["Priority"].ToString();
            txtDescription.Text = row["Description"].ToString();
            cmbBrigade.SelectedValue = row["BrigadeID"] == DBNull.Value ? 0 : (int)row["BrigadeID"];
            oldStatus = row["Status"].ToString();
            cmbStatus.SelectedItem = oldStatus;
            txtResult.Text = row["Result"].ToString();
            closedAt = row["ClosedAt"] == DBNull.Value ? (DateTime?)null : (DateTime)row["ClosedAt"];

            lblInfo.Text = "Принял: " + row["Dispatcher"] +
                "     Бригада назначена: " + FormatDate(row["AssignedAt"]) +
                "     Выполнена: " + FormatDate(row["ClosedAt"]);

            DataTable shutdown = Db.GetTable("SELECT StreetID, Houses, StartAt, EndAt FROM Shutdowns WHERE RequestID = @id",
                new SqlParameter("@id", requestId));
            if (shutdown.Rows.Count > 0)
            {
                chkShutdown.Checked = true;
                cmbShutStreet.SelectedValue = shutdown.Rows[0]["StreetID"];
                txtShutHouses.Text = shutdown.Rows[0]["Houses"].ToString();
                dtpShutStart.Value = (DateTime)shutdown.Rows[0]["StartAt"];
                dtpShutEnd.Value = (DateTime)shutdown.Rows[0]["EndAt"];
            }
            else
            {
                cmbShutStreet.SelectedValue = row["StreetID"];
                dtpShutStart.Value = DateTime.Now;
                dtpShutEnd.Value = DateTime.Now.AddHours(4);
            }
            return true;
        }

        private string FormatDate(object value)
        {
            return value == DBNull.Value ? "—" : ((DateTime)value).ToString("dd.MM.yyyy HH:mm");
        }

        private void LoadMaterials()
        {
            materials = Db.GetTable("SELECT rm.MaterialID, m.Name AS [Материал], m.Unit AS [Ед. изм.], rm.Quantity AS [Количество], " +
                "rm.Price AS [Цена], rm.Quantity * rm.Price AS [Сумма] " +
                "FROM RequestMaterials rm JOIN Materials m ON m.MaterialID = rm.MaterialID WHERE rm.RequestID = @id",
                new SqlParameter("@id", requestId));
            dgvMaterials.DataSource = materials;
            dgvMaterials.Columns["MaterialID"].Visible = false;
            dgvMaterials.Columns["Материал"].FillWeight = 250;
            dgvMaterials.Columns["Цена"].DefaultCellStyle.Format = "N2";
            dgvMaterials.Columns["Сумма"].DefaultCellStyle.Format = "N2";
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in materials.Rows)
                total += (decimal)row["Сумма"];
            lblTotal.Text = "Итого материалов на сумму: " + total.ToString("N2") + " руб.";
        }

        private void ApplyRole()
        {
            if (Session.Role != "Мастер")
                return;

            foreach (Control control in new Control[] { dtpCreated, txtApplicant, txtPhone, cmbStreet, txtHouse,
                cmbType, cmbPriority, txtDescription, cmbBrigade, chkShutdown })
                control.Enabled = false;

            if (oldStatus == "Отменена")
                cmbStatus.Enabled = false;
            else
                cmbStatus.Items.Remove("Отменена");
        }

        private void UpdateShutdownControls()
        {
            bool enabled = chkShutdown.Checked && chkShutdown.Enabled;
            cmbShutStreet.Enabled = enabled;
            txtShutHouses.Enabled = enabled;
            dtpShutStart.Enabled = enabled;
            dtpShutEnd.Enabled = enabled;
        }

        private void chkShutdown_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShutdownControls();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedValue == null)
                return;

            DataRowView item = (DataRowView)cmbMaterial.SelectedItem;
            int materialId = (int)item["MaterialID"];
            decimal quantity = numQuantity.Value;

            foreach (DataRow row in materials.Rows)
            {
                if ((int)row["MaterialID"] == materialId)
                {
                    row["Количество"] = (decimal)row["Количество"] + quantity;
                    row["Сумма"] = (decimal)row["Количество"] * (decimal)row["Цена"];
                    UpdateTotal();
                    return;
                }
            }

            decimal price = (decimal)item["Price"];
            materials.Rows.Add(materialId, item["Name"], item["Unit"], quantity, price, quantity * price);
            UpdateTotal();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.CurrentRow == null)
                return;
            materials.Rows.Remove(((DataRowView)dgvMaterials.CurrentRow.DataBoundItem).Row);
            UpdateTotal();
        }

        private int? SelectedBrigade()
        {
            if (cmbBrigade.SelectedValue == null || (int)cmbBrigade.SelectedValue == 0)
                return null;
            return (int)cmbBrigade.SelectedValue;
        }

        private bool CheckFields()
        {
            string errors = "";
            string status = cmbStatus.Text;

            if (txtApplicant.Text.Trim() == "")
                errors += "— укажите заявителя\n";
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^[0-9+\-() ]{5,20}$"))
                errors += "— телефон указан неверно (цифры, +, -, скобки)\n";
            if (cmbStreet.SelectedValue == null)
                errors += "— выберите улицу\n";
            if (txtHouse.Text.Trim() == "")
                errors += "— укажите номер дома\n";
            if (cmbType.SelectedValue == null)
                errors += "— выберите тип аварии\n";
            if (txtDescription.Text.Trim() == "")
                errors += "— опишите проблему\n";
            if (dtpCreated.Value > DateTime.Now)
                errors += "— дата приёма не может быть в будущем\n";
            if (closedAt != null && status == "Выполнена" && dtpCreated.Value > closedAt)
                errors += "— дата приёма позже даты выполнения\n";
            if ((status == "В работе" || status == "Выполнена") && SelectedBrigade() == null)
                errors += "— для статуса «" + status + "» нужно назначить бригаду\n";
            if (status == "Выполнена" && txtResult.Text.Trim() == "")
                errors += "— опишите выполненные работы\n";
            if (chkShutdown.Checked)
            {
                if (cmbShutStreet.SelectedValue == null || txtShutHouses.Text.Trim() == "")
                    errors += "— укажите улицу и дома для отключения\n";
                if (dtpShutEnd.Value <= dtpShutStart.Value)
                    errors += "— окончание отключения должно быть позже начала\n";
            }

            if (errors == "")
                return true;
            MessageBox.Show("Проверьте данные:\n" + errors, "Заявка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;
            try
            {
                SaveRequest();
                DialogResult = DialogResult.OK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Не удалось сохранить заявку: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRequest()
        {
            using (var connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    var command = new SqlCommand("", connection, transaction);
                    command.Parameters.Add("@created", SqlDbType.DateTime).Value = dtpCreated.Value;
                    command.Parameters.Add("@applicant", SqlDbType.NVarChar, 150).Value = txtApplicant.Text.Trim();
                    command.Parameters.Add("@phone", SqlDbType.NVarChar, 20).Value = txtPhone.Text.Trim();
                    command.Parameters.Add("@street", SqlDbType.Int).Value = cmbStreet.SelectedValue;
                    command.Parameters.Add("@house", SqlDbType.NVarChar, 10).Value = txtHouse.Text.Trim();
                    command.Parameters.Add("@type", SqlDbType.Int).Value = cmbType.SelectedValue;
                    command.Parameters.Add("@priority", SqlDbType.NVarChar, 20).Value = cmbPriority.Text;
                    command.Parameters.Add("@description", SqlDbType.NVarChar, 500).Value = txtDescription.Text.Trim();
                    command.Parameters.Add("@status", SqlDbType.NVarChar, 20).Value = cmbStatus.Text;
                    command.Parameters.Add("@brigade", SqlDbType.Int).Value = (object)SelectedBrigade() ?? DBNull.Value;
                    command.Parameters.Add("@result", SqlDbType.NVarChar, 500).Value = txtResult.Text.Trim() == "" ? (object)DBNull.Value : txtResult.Text.Trim();

                    int id = requestId;
                    if (id == 0)
                    {
                        command.Parameters.Add("@dispatcher", SqlDbType.Int).Value = Session.UserID;
                        command.CommandText = "INSERT INTO Requests (CreatedAt, ApplicantName, ApplicantPhone, StreetID, House, TypeID, Priority, " +
                            "Description, Status, BrigadeID, DispatcherID, AssignedAt, ClosedAt, Result) VALUES (@created, @applicant, @phone, " +
                            "@street, @house, @type, @priority, @description, @status, @brigade, @dispatcher, " +
                            "CASE WHEN @brigade IS NULL THEN NULL ELSE GETDATE() END, " +
                            "CASE WHEN @status = N'Выполнена' THEN GETDATE() ELSE NULL END, @result); SELECT SCOPE_IDENTITY();";
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                    else
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.CommandText = "UPDATE Requests SET CreatedAt = @created, ApplicantName = @applicant, ApplicantPhone = @phone, " +
                            "StreetID = @street, House = @house, TypeID = @type, Priority = @priority, Description = @description, " +
                            "AssignedAt = CASE WHEN @brigade IS NULL THEN NULL WHEN BrigadeID IS NULL OR BrigadeID <> @brigade THEN GETDATE() ELSE AssignedAt END, " +
                            "ClosedAt = CASE WHEN @status = N'Выполнена' THEN ISNULL(ClosedAt, GETDATE()) ELSE NULL END, " +
                            "BrigadeID = @brigade, Status = @status, Result = @result WHERE RequestID = @id";
                        command.ExecuteNonQuery();
                    }

                    command.Parameters.Clear();
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandText = "DELETE FROM RequestMaterials WHERE RequestID = @id; DELETE FROM Shutdowns WHERE RequestID = @id;";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO RequestMaterials (RequestID, MaterialID, Quantity, Price) VALUES (@id, @material, @quantity, @price)";
                    command.Parameters.Add("@material", SqlDbType.Int);
                    command.Parameters.Add("@quantity", SqlDbType.Decimal).Precision = 10;
                    command.Parameters["@quantity"].Scale = 2;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Precision = 10;
                    command.Parameters["@price"].Scale = 2;
                    foreach (DataRow row in materials.Rows)
                    {
                        command.Parameters["@material"].Value = row["MaterialID"];
                        command.Parameters["@quantity"].Value = row["Количество"];
                        command.Parameters["@price"].Value = row["Цена"];
                        command.ExecuteNonQuery();
                    }

                    if (chkShutdown.Checked)
                    {
                        command.Parameters.Clear();
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.Parameters.Add("@street", SqlDbType.Int).Value = cmbShutStreet.SelectedValue;
                        command.Parameters.Add("@houses", SqlDbType.NVarChar, 200).Value = txtShutHouses.Text.Trim();
                        command.Parameters.Add("@start", SqlDbType.DateTime).Value = dtpShutStart.Value;
                        command.Parameters.Add("@end", SqlDbType.DateTime).Value = dtpShutEnd.Value;
                        command.CommandText = "INSERT INTO Shutdowns (RequestID, StreetID, Houses, StartAt, EndAt) VALUES (@id, @street, @houses, @start, @end)";
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    requestId = id;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
