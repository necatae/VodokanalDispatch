using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable user;
            try
            {
                user = Db.GetTable("SELECT UserID, FullName, Role, BrigadeID FROM Users " +
                    "WHERE Login = @login AND PasswordHash = HASHBYTES('SHA2_256', @password) AND IsActive = 1",
                    new SqlParameter("@login", SqlDbType.NVarChar, 50) { Value = txtLogin.Text.Trim() },
                    new SqlParameter("@password", SqlDbType.NVarChar, 100) { Value = txtPassword.Text });
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных.\nПроверьте строку подключения в файле VodokanalDispatch.exe.config.\n\n" + ex.Message,
                    "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DataRow row = user.Rows[0];
            Session.UserID = (int)row["UserID"];
            Session.FullName = row["FullName"].ToString();
            Session.Role = row["Role"].ToString();
            Session.BrigadeID = row["BrigadeID"] == DBNull.Value ? (int?)null : (int)row["BrigadeID"];
            DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
