using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class DictionaryForm : Form
    {
        private string tableName;
        private Dictionary<string, string> headers;
        private Dictionary<string, string> lookups;
        private SqlDataAdapter adapter;
        private DataTable table;

        public DictionaryForm(string title, string tableName, Dictionary<string, string> headers, Dictionary<string, string> lookups)
        {
            InitializeComponent();
            Text = "Справочник: " + title;
            this.tableName = tableName;
            this.headers = headers;
            this.lookups = lookups ?? new Dictionary<string, string>();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки справочника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadData()
        {
            adapter = new SqlDataAdapter("SELECT * FROM " + tableName, Db.ConnectionString);
            new SqlCommandBuilder(adapter);
            table = new DataTable();
            adapter.FillSchema(table, SchemaType.Source);
            foreach (DataColumn column in table.Columns)
            {
                if (column.AutoIncrement)
                {
                    column.AutoIncrementSeed = -1;
                    column.AutoIncrementStep = -1;
                }
            }
            adapter.Fill(table);

            dgvData.AutoGenerateColumns = false;
            dgvData.Columns.Clear();
            foreach (DataColumn column in table.Columns)
            {
                DataGridViewColumn gridColumn;
                if (lookups.ContainsKey(column.ColumnName))
                {
                    DataTable lookup = Db.GetTable(lookups[column.ColumnName]);
                    var combo = new DataGridViewComboBoxColumn();
                    combo.DataSource = lookup;
                    combo.ValueMember = lookup.Columns[0].ColumnName;
                    combo.DisplayMember = lookup.Columns[1].ColumnName;
                    combo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                    gridColumn = combo;
                }
                else
                {
                    gridColumn = new DataGridViewTextBoxColumn();
                }
                gridColumn.DataPropertyName = column.ColumnName;
                gridColumn.Name = column.ColumnName;
                gridColumn.HeaderText = headers.ContainsKey(column.ColumnName) ? headers[column.ColumnName] : column.ColumnName;
                gridColumn.Visible = !column.AutoIncrement;
                dgvData.Columns.Add(gridColumn);
            }
            dgvData.DataSource = table;
            lblCount.Text = "Записей: " + table.Rows.Count;
        }

        private bool SaveData()
        {
            try
            {
                dgvData.EndEdit();
                BindingContext[table].EndCurrentEdit();
                adapter.Update(table);
                LoadData();
                return true;
            }
            catch (DataException ex)
            {
                MessageBox.Show("Проверьте введённые данные: " + ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                if (ex.Number == 547)
                    message = "Запись используется в других таблицах или значение не подходит по ограничениям, поэтому изменение невозможно.";
                else if (ex.Number == 2627 || ex.Number == 2601)
                    message = "Такая запись уже есть в справочнике.";
                else if (ex.Number == 515)
                    message = "Заполните все обязательные поля.";
                MessageBox.Show(message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
                MessageBox.Show("Изменения сохранены", "Справочник", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DictionaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (table == null)
                return;
            dgvData.EndEdit();
            if (table.GetChanges() == null)
                return;

            DialogResult answer = MessageBox.Show("Сохранить изменения?", "Справочник", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (answer == DialogResult.Cancel || (answer == DialogResult.Yes && !SaveData()))
                e.Cancel = true;
        }

        private void dgvData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректное значение: " + e.Exception.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }

        private void dgvData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
