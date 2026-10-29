namespace VodokanalDispatch
{
    partial class RequestForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.grpWork = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbBrigade = new System.Windows.Forms.ComboBox();
            this.lblBrigade = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.lblCreated = new System.Windows.Forms.Label();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.tabShutdown = new System.Windows.Forms.TabPage();
            this.lblShutHint = new System.Windows.Forms.Label();
            this.dtpShutEnd = new System.Windows.Forms.DateTimePicker();
            this.lblShutEnd = new System.Windows.Forms.Label();
            this.dtpShutStart = new System.Windows.Forms.DateTimePicker();
            this.lblShutStart = new System.Windows.Forms.Label();
            this.txtShutHouses = new System.Windows.Forms.TextBox();
            this.lblShutHouses = new System.Windows.Forms.Label();
            this.cmbShutStreet = new System.Windows.Forms.ComboBox();
            this.lblShutStreet = new System.Windows.Forms.Label();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.grpWork.SuspendLayout();
            this.tabMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.tabShutdown.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl
            //
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabMaterials);
            this.tabControl.Controls.Add(this.tabShutdown);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(746, 530);
            this.tabControl.TabIndex = 0;
            //
            // tabMain
            //
            this.tabMain.Controls.Add(this.grpWork);
            this.tabMain.Controls.Add(this.txtDescription);
            this.tabMain.Controls.Add(this.lblDescription);
            this.tabMain.Controls.Add(this.cmbType);
            this.tabMain.Controls.Add(this.lblType);
            this.tabMain.Controls.Add(this.txtHouse);
            this.tabMain.Controls.Add(this.lblHouse);
            this.tabMain.Controls.Add(this.cmbStreet);
            this.tabMain.Controls.Add(this.lblStreet);
            this.tabMain.Controls.Add(this.txtPhone);
            this.tabMain.Controls.Add(this.lblPhone);
            this.tabMain.Controls.Add(this.txtApplicant);
            this.tabMain.Controls.Add(this.lblApplicant);
            this.tabMain.Controls.Add(this.cmbPriority);
            this.tabMain.Controls.Add(this.lblPriority);
            this.tabMain.Controls.Add(this.dtpCreated);
            this.tabMain.Controls.Add(this.lblCreated);
            this.tabMain.Location = new System.Drawing.Point(4, 26);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(738, 500);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Заявка";
            this.tabMain.UseVisualStyleBackColor = true;
            //
            // lblCreated
            //
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(15, 19);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(88, 19);
            this.lblCreated.TabIndex = 0;
            this.lblCreated.Text = "Дата приёма";
            //
            // dtpCreated
            //
            this.dtpCreated.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreated.Location = new System.Drawing.Point(140, 15);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(230, 25);
            this.dtpCreated.TabIndex = 1;
            //
            // lblPriority
            //
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(395, 19);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(73, 19);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Приоритет";
            //
            // cmbPriority
            //
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Location = new System.Drawing.Point(500, 15);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(220, 25);
            this.cmbPriority.TabIndex = 3;
            //
            // lblApplicant
            //
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Location = new System.Drawing.Point(15, 54);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(69, 19);
            this.lblApplicant.TabIndex = 4;
            this.lblApplicant.Text = "Заявитель";
            //
            // txtApplicant
            //
            this.txtApplicant.Location = new System.Drawing.Point(140, 50);
            this.txtApplicant.MaxLength = 150;
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.Size = new System.Drawing.Size(230, 25);
            this.txtApplicant.TabIndex = 5;
            //
            // lblPhone
            //
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(395, 54);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 19);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон";
            //
            // txtPhone
            //
            this.txtPhone.Location = new System.Drawing.Point(500, 50);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 25);
            this.txtPhone.TabIndex = 7;
            //
            // lblStreet
            //
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(15, 89);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 19);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Улица";
            //
            // cmbStreet
            //
            this.cmbStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStreet.Location = new System.Drawing.Point(140, 85);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(230, 25);
            this.cmbStreet.TabIndex = 9;
            //
            // lblHouse
            //
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(395, 89);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(34, 19);
            this.lblHouse.TabIndex = 10;
            this.lblHouse.Text = "Дом";
            //
            // txtHouse
            //
            this.txtHouse.Location = new System.Drawing.Point(500, 85);
            this.txtHouse.MaxLength = 10;
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(100, 25);
            this.txtHouse.TabIndex = 11;
            //
            // lblType
            //
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 124);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 19);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Тип аварии";
            //
            // cmbType
            //
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(140, 120);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(580, 25);
            this.cmbType.TabIndex = 13;
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 159);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 19);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Описание";
            //
            // txtDescription
            //
            this.txtDescription.Location = new System.Drawing.Point(140, 155);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(580, 75);
            this.txtDescription.TabIndex = 15;
            //
            // grpWork
            //
            this.grpWork.Controls.Add(this.lblInfo);
            this.grpWork.Controls.Add(this.txtResult);
            this.grpWork.Controls.Add(this.lblResult);
            this.grpWork.Controls.Add(this.cmbStatus);
            this.grpWork.Controls.Add(this.lblStatus);
            this.grpWork.Controls.Add(this.cmbBrigade);
            this.grpWork.Controls.Add(this.lblBrigade);
            this.grpWork.Location = new System.Drawing.Point(15, 245);
            this.grpWork.Name = "grpWork";
            this.grpWork.Size = new System.Drawing.Size(705, 240);
            this.grpWork.TabIndex = 16;
            this.grpWork.TabStop = false;
            this.grpWork.Text = "Выполнение";
            //
            // lblBrigade
            //
            this.lblBrigade.AutoSize = true;
            this.lblBrigade.Location = new System.Drawing.Point(15, 34);
            this.lblBrigade.Name = "lblBrigade";
            this.lblBrigade.Size = new System.Drawing.Size(59, 19);
            this.lblBrigade.TabIndex = 0;
            this.lblBrigade.Text = "Бригада";
            //
            // cmbBrigade
            //
            this.cmbBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigade.Location = new System.Drawing.Point(125, 30);
            this.cmbBrigade.Name = "cmbBrigade";
            this.cmbBrigade.Size = new System.Drawing.Size(230, 25);
            this.cmbBrigade.TabIndex = 1;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(380, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус";
            //
            // cmbStatus
            //
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(485, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(205, 25);
            this.cmbStatus.TabIndex = 3;
            //
            // lblResult
            //
            this.lblResult.Location = new System.Drawing.Point(15, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 40);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Результат работ";
            //
            // txtResult
            //
            this.txtResult.Location = new System.Drawing.Point(125, 67);
            this.txtResult.MaxLength = 500;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(565, 100);
            this.txtResult.TabIndex = 5;
            //
            // lblInfo
            //
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(15, 180);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(675, 45);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Принял:";
            //
            // tabMaterials
            //
            this.tabMaterials.Controls.Add(this.lblTotal);
            this.tabMaterials.Controls.Add(this.dgvMaterials);
            this.tabMaterials.Controls.Add(this.btnRemoveMaterial);
            this.tabMaterials.Controls.Add(this.btnAddMaterial);
            this.tabMaterials.Controls.Add(this.numQuantity);
            this.tabMaterials.Controls.Add(this.cmbMaterial);
            this.tabMaterials.Location = new System.Drawing.Point(4, 26);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterials.Size = new System.Drawing.Size(738, 500);
            this.tabMaterials.TabIndex = 1;
            this.tabMaterials.Text = "Материалы";
            this.tabMaterials.UseVisualStyleBackColor = true;
            //
            // cmbMaterial
            //
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Location = new System.Drawing.Point(15, 16);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(400, 25);
            this.cmbMaterial.TabIndex = 0;
            //
            // numQuantity
            //
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.Location = new System.Drawing.Point(425, 16);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(90, 25);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // btnAddMaterial
            //
            this.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial.Location = new System.Drawing.Point(525, 13);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(95, 31);
            this.btnAddMaterial.TabIndex = 2;
            this.btnAddMaterial.Text = "Добавить";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            //
            // btnRemoveMaterial
            //
            this.btnRemoveMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMaterial.Location = new System.Drawing.Point(625, 13);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(95, 31);
            this.btnRemoveMaterial.TabIndex = 3;
            this.btnRemoveMaterial.Text = "Удалить";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            //
            // dgvMaterials
            //
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(15, 55);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.RowHeadersVisible = false;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(705, 390);
            this.dgvMaterials.TabIndex = 4;
            //
            // lblTotal
            //
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(15, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(705, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Итого:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // tabShutdown
            //
            this.tabShutdown.Controls.Add(this.lblShutHint);
            this.tabShutdown.Controls.Add(this.dtpShutEnd);
            this.tabShutdown.Controls.Add(this.lblShutEnd);
            this.tabShutdown.Controls.Add(this.dtpShutStart);
            this.tabShutdown.Controls.Add(this.lblShutStart);
            this.tabShutdown.Controls.Add(this.txtShutHouses);
            this.tabShutdown.Controls.Add(this.lblShutHouses);
            this.tabShutdown.Controls.Add(this.cmbShutStreet);
            this.tabShutdown.Controls.Add(this.lblShutStreet);
            this.tabShutdown.Controls.Add(this.chkShutdown);
            this.tabShutdown.Location = new System.Drawing.Point(4, 26);
            this.tabShutdown.Name = "tabShutdown";
            this.tabShutdown.Padding = new System.Windows.Forms.Padding(3);
            this.tabShutdown.Size = new System.Drawing.Size(738, 500);
            this.tabShutdown.TabIndex = 2;
            this.tabShutdown.Text = "Отключение воды";
            this.tabShutdown.UseVisualStyleBackColor = true;
            //
            // chkShutdown
            //
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Location = new System.Drawing.Point(15, 18);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(270, 23);
            this.chkShutdown.TabIndex = 0;
            this.chkShutdown.Text = "Требуется отключение водоснабжения";
            this.chkShutdown.UseVisualStyleBackColor = true;
            this.chkShutdown.CheckedChanged += new System.EventHandler(this.chkShutdown_CheckedChanged);
            //
            // lblShutStreet
            //
            this.lblShutStreet.AutoSize = true;
            this.lblShutStreet.Location = new System.Drawing.Point(15, 60);
            this.lblShutStreet.Name = "lblShutStreet";
            this.lblShutStreet.Size = new System.Drawing.Size(45, 19);
            this.lblShutStreet.TabIndex = 1;
            this.lblShutStreet.Text = "Улица";
            //
            // cmbShutStreet
            //
            this.cmbShutStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShutStreet.Location = new System.Drawing.Point(175, 56);
            this.cmbShutStreet.Name = "cmbShutStreet";
            this.cmbShutStreet.Size = new System.Drawing.Size(300, 25);
            this.cmbShutStreet.TabIndex = 2;
            //
            // lblShutHouses
            //
            this.lblShutHouses.AutoSize = true;
            this.lblShutHouses.Location = new System.Drawing.Point(15, 95);
            this.lblShutHouses.Name = "lblShutHouses";
            this.lblShutHouses.Size = new System.Drawing.Size(104, 19);
            this.lblShutHouses.TabIndex = 3;
            this.lblShutHouses.Text = "Дома (номера)";
            //
            // txtShutHouses
            //
            this.txtShutHouses.Location = new System.Drawing.Point(175, 91);
            this.txtShutHouses.MaxLength = 200;
            this.txtShutHouses.Name = "txtShutHouses";
            this.txtShutHouses.Size = new System.Drawing.Size(300, 25);
            this.txtShutHouses.TabIndex = 4;
            //
            // lblShutStart
            //
            this.lblShutStart.AutoSize = true;
            this.lblShutStart.Location = new System.Drawing.Point(15, 130);
            this.lblShutStart.Name = "lblShutStart";
            this.lblShutStart.Size = new System.Drawing.Size(132, 19);
            this.lblShutStart.TabIndex = 5;
            this.lblShutStart.Text = "Начало отключения";
            //
            // dtpShutStart
            //
            this.dtpShutStart.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpShutStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShutStart.Location = new System.Drawing.Point(175, 126);
            this.dtpShutStart.Name = "dtpShutStart";
            this.dtpShutStart.Size = new System.Drawing.Size(200, 25);
            this.dtpShutStart.TabIndex = 6;
            //
            // lblShutEnd
            //
            this.lblShutEnd.AutoSize = true;
            this.lblShutEnd.Location = new System.Drawing.Point(15, 165);
            this.lblShutEnd.Name = "lblShutEnd";
            this.lblShutEnd.Size = new System.Drawing.Size(120, 19);
            this.lblShutEnd.TabIndex = 7;
            this.lblShutEnd.Text = "Окончание (план)";
            //
            // dtpShutEnd
            //
            this.dtpShutEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpShutEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShutEnd.Location = new System.Drawing.Point(175, 161);
            this.dtpShutEnd.Name = "dtpShutEnd";
            this.dtpShutEnd.Size = new System.Drawing.Size(200, 25);
            this.dtpShutEnd.TabIndex = 8;
            //
            // lblShutHint
            //
            this.lblShutHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblShutHint.Location = new System.Drawing.Point(15, 205);
            this.lblShutHint.Name = "lblShutHint";
            this.lblShutHint.Size = new System.Drawing.Size(705, 45);
            this.lblShutHint.TabIndex = 9;
            this.lblShutHint.Text = "Номера домов указываются через запятую. Сведения об отключении нужны для оповещения абонентов.";
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(488, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(628, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // RequestForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(770, 598);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.grpWork.ResumeLayout(false);
            this.grpWork.PerformLayout();
            this.tabMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.tabShutdown.ResumeLayout(false);
            this.tabShutdown.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.GroupBox grpWork;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbBrigade;
        private System.Windows.Forms.Label lblBrigade;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cmbStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TabPage tabShutdown;
        private System.Windows.Forms.Label lblShutHint;
        private System.Windows.Forms.DateTimePicker dtpShutEnd;
        private System.Windows.Forms.Label lblShutEnd;
        private System.Windows.Forms.DateTimePicker dtpShutStart;
        private System.Windows.Forms.Label lblShutStart;
        private System.Windows.Forms.TextBox txtShutHouses;
        private System.Windows.Forms.Label lblShutHouses;
        private System.Windows.Forms.ComboBox cmbShutStreet;
        private System.Windows.Forms.Label lblShutStreet;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
