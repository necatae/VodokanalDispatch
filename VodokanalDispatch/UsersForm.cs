using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class UsersForm : Form
    {
        private int userId = 0;

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new object[] { "Администратор", "Диспетчер", "Мастер" });
            try
            {
                DataTable brigades = Db.GetTable("SELECT BrigadeID, Name FROM Brigades ORDER BY Name");
                DataRow none = brigades.NewRow();
                none["BrigadeID"] = 0;
                none["Name"] = "(нет)";
                brigades.Rows.InsertAt(none, 0);
                cmbBrigade.DisplayMember = "Name";
                cmbBrigade.ValueMember = "BrigadeID";
                cmbBrigade.DataSource = brigades;
                LoadUsers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            ClearFields();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = Db.GetTable("SELECT u.UserID, u.BrigadeID, u.Login AS [Логин], u.FullName AS [ФИО], u.Role AS [Роль], " +
                "b.Name AS [Бригада], u.IsActive AS [Активен] FROM Users u LEFT JOIN Brigades b ON b.BrigadeID = u.BrigadeID ORDER BY u.FullName");
            dgvUsers.Columns["UserID"].Visible = false;
            dgvUsers.Columns["BrigadeID"].Visible = false;
        }

        private void ClearFields()
        {
            userId = 0;
            txtLogin.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            cmbRole.SelectedItem = "Диспетчер";
            cmbBrigade.SelectedValue = 0;
            chkActive.Checked = true;
            lblMode.Text = "Новый пользователь";
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            userId = (int)row.Cells["UserID"].Value;
            txtLogin.Text = row.Cells["Логин"].Value.ToString();
            txtFullName.Text = row.Cells["ФИО"].Value.ToString();
            cmbRole.SelectedItem = row.Cells["Роль"].Value.ToString();
            cmbBrigade.SelectedValue = row.Cells["BrigadeID"].Value == DBNull.Value ? 0 : (int)row.Cells["BrigadeID"].Value;
            chkActive.Checked = (bool)row.Cells["Активен"].Value;
            txtPassword.Clear();
            lblMode.Text = "Редактирование: " + txtLogin.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtLogin.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = cmbRole.Text;
            int brigade = (int)cmbBrigade.SelectedValue;
            string errors = "";
            if (txtLogin.Text.Trim() == "")
                errors += "— укажите логин\n";
            if (txtFullName.Text.Trim() == "")
                errors += "— укажите ФИО\n";
            if (userId == 0 && txtPassword.Text.Length < 4)
                errors += "— пароль должен быть не короче 4 символов\n";
            if (userId != 0 && txtPassword.Text.Length > 0 && txtPassword.Text.Length < 4)
                errors += "— новый пароль должен быть не короче 4 символов\n";
            if (role == "Мастер" && brigade == 0)
                errors += "— для мастера выберите бригаду\n";
            if (userId == Session.UserID && (!chkActive.Checked || role != "Администратор"))
                errors += "— нельзя отключить или понизить свою учётную запись\n";
            if (errors != "")
            {
                MessageBox.Show("Проверьте данные:\n" + errors, "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = userId == 0
                ? "INSERT INTO Users (Login, PasswordHash, FullName, Role, BrigadeID, IsActive) " +
                  "VALUES (@login, HASHBYTES('SHA2_256', @password), @fullName, @role, @brigade, @active)"
                : "UPDATE Users SET Login = @login, FullName = @fullName, Role = @role, BrigadeID = @brigade, IsActive = @active, " +
                  "PasswordHash = CASE WHEN @password = N'' THEN PasswordHash ELSE HASHBYTES('SHA2_256', @password) END WHERE UserID = @id";
            try
            {
                Db.Execute(sql,
                    new SqlParameter("@login", SqlDbType.NVarChar, 50) { Value = txtLogin.Text.Trim() },
                    new SqlParameter("@password", SqlDbType.NVarChar, 100) { Value = txtPassword.Text },
                    new SqlParameter("@fullName", SqlDbType.NVarChar, 150) { Value = txtFullName.Text.Trim() },
                    new SqlParameter("@role", SqlDbType.NVarChar, 20) { Value = role },
                    new SqlParameter("@brigade", SqlDbType.Int) { Value = role == "Мастер" ? (object)brigade : DBNull.Value },
                    new SqlParameter("@active", SqlDbType.Bit) { Value = chkActive.Checked },
                    new SqlParameter("@id", SqlDbType.Int) { Value = userId });
                LoadUsers();
                ClearFields();
                MessageBox.Show("Пользователь сохранён", "Пользователи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Number == 2627 || ex.Number == 2601 ? "Такой логин уже занят" : ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
