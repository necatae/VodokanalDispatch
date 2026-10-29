namespace VodokanalDispatch
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cmbBrigade = new System.Windows.Forms.ComboBox();
            this.lblBrigade = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvUsers
            //
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(580, 480);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            //
            // pnlEdit
            //
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlEdit.Controls.Add(this.btnClose);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.btnNew);
            this.pnlEdit.Controls.Add(this.txtPassword);
            this.pnlEdit.Controls.Add(this.lblPassword);
            this.pnlEdit.Controls.Add(this.chkActive);
            this.pnlEdit.Controls.Add(this.cmbBrigade);
            this.pnlEdit.Controls.Add(this.lblBrigade);
            this.pnlEdit.Controls.Add(this.cmbRole);
            this.pnlEdit.Controls.Add(this.lblRole);
            this.pnlEdit.Controls.Add(this.txtFullName);
            this.pnlEdit.Controls.Add(this.lblFullName);
            this.pnlEdit.Controls.Add(this.txtLogin);
            this.pnlEdit.Controls.Add(this.lblLogin);
            this.pnlEdit.Controls.Add(this.lblMode);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEdit.Location = new System.Drawing.Point(580, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(320, 480);
            this.pnlEdit.TabIndex = 1;
            //
            // lblMode
            //
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMode.Location = new System.Drawing.Point(15, 15);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(290, 22);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Новый пользователь";
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 50);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            //
            // txtLogin
            //
            this.txtLogin.Location = new System.Drawing.Point(15, 72);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(290, 25);
            this.txtLogin.TabIndex = 2;
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 105);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(37, 19);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "ФИО";
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(15, 127);
            this.txtFullName.MaxLength = 150;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(290, 25);
            this.txtFullName.TabIndex = 4;
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(15, 160);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 19);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Роль";
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Location = new System.Drawing.Point(15, 182);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(290, 25);
            this.cmbRole.TabIndex = 6;
            //
            // lblBrigade
            //
            this.lblBrigade.AutoSize = true;
            this.lblBrigade.Location = new System.Drawing.Point(15, 215);
            this.lblBrigade.Name = "lblBrigade";
            this.lblBrigade.Size = new System.Drawing.Size(150, 19);
            this.lblBrigade.TabIndex = 7;
            this.lblBrigade.Text = "Бригада (для мастера)";
            //
            // cmbBrigade
            //
            this.cmbBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigade.Location = new System.Drawing.Point(15, 237);
            this.cmbBrigade.Name = "cmbBrigade";
            this.cmbBrigade.Size = new System.Drawing.Size(290, 25);
            this.cmbBrigade.TabIndex = 8;
            //
            // chkActive
            //
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(15, 274);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(185, 23);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Учётная запись активна";
            this.chkActive.UseVisualStyleBackColor = true;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 307);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(230, 19);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Пароль (пусто — оставить прежний)";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(15, 329);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 25);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // btnNew
            //
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(15, 375);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 34);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(165, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnClose
            //
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(165, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // UsersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "UsersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи системы";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cmbBrigade;
        private System.Windows.Forms.Label lblBrigade;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMode;
    }
}
