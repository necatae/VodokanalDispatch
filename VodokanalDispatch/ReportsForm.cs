using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class ReportsForm : Form
    {
        private readonly string[] procedures = { "ReportByTypeAndDistrict", "ReportTopStreets", "ReportBrigades", "ReportByMonth" };

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbReport.Items.AddRange(new object[] {
                "Время устранения аварий по районам и типам",
                "Самые аварийные улицы (топ-10)",
                "Загрузка бригад",
                "Количество аварий по месяцам" });
            cmbReport.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpTo.Value = DateTime.Today;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Начало периода не может быть позже окончания", "Отчёт", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                dgvReport.DataSource = Db.GetTable("EXEC " + procedures[cmbReport.SelectedIndex] + " @DateFrom, @DateTo",
                    new SqlParameter("@DateFrom", dtpFrom.Value.Date),
                    new SqlParameter("@DateTo", dtpTo.Value.Date));
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    if (column.ValueType == typeof(DateTime))
                        column.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                    else if (column.ValueType == typeof(decimal) && column.HeaderText.Contains("руб"))
                        column.DefaultCellStyle.Format = "N2";
                }
                lblInfo.Text = cmbReport.Text + " за период с " + dtpFrom.Value.ToShortDateString() + " по " + dtpTo.Value.ToShortDateString() +
                    ". Строк: " + dgvReport.Rows.Count;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка формирования отчёта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            CsvExport.Save(dgvReport, cmbReport.Text);
        }
    }
}
