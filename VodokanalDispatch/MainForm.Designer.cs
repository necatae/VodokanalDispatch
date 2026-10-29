namespace VodokanalDispatch
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDictionaries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDistricts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStreets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrigades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLegend = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRequests,
            this.mnuDictionaries,
            this.mnuReports,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 27);
            this.menuStrip.TabIndex = 0;
            //
            // mnuFile
            //
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExport,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 23);
            this.mnuFile.Text = "Файл";
            //
            // mnuExport
            //
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(300, 24);
            this.mnuExport.Text = "Экспорт списка в Excel (CSV)...";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            //
            // mnuExit
            //
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(300, 24);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            //
            // mnuRequests
            //
            this.mnuRequests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewRequest,
            this.mnuOpenRequest,
            this.mnuRefresh});
            this.mnuRequests.Name = "mnuRequests";
            this.mnuRequests.Size = new System.Drawing.Size(67, 23);
            this.mnuRequests.Text = "Заявки";
            //
            // mnuNewRequest
            //
            this.mnuNewRequest.Name = "mnuNewRequest";
            this.mnuNewRequest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewRequest.Size = new System.Drawing.Size(240, 24);
            this.mnuNewRequest.Text = "Новая заявка";
            this.mnuNewRequest.Click += new System.EventHandler(this.btnNew_Click);
            //
            // mnuOpenRequest
            //
            this.mnuOpenRequest.Name = "mnuOpenRequest";
            this.mnuOpenRequest.Size = new System.Drawing.Size(240, 24);
            this.mnuOpenRequest.Text = "Открыть заявку";
            this.mnuOpenRequest.Click += new System.EventHandler(this.btnOpen_Click);
            //
            // mnuRefresh
            //
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRefresh.Size = new System.Drawing.Size(240, 24);
            this.mnuRefresh.Text = "Обновить";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            //
            // mnuDictionaries
            //
            this.mnuDictionaries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDistricts,
            this.mnuStreets,
            this.mnuTypes,
            this.mnuBrigades,
            this.mnuEmployees,
            this.mnuMaterials,
            this.mnuSeparator,
            this.mnuUsers});
            this.mnuDictionaries.Name = "mnuDictionaries";
            this.mnuDictionaries.Size = new System.Drawing.Size(107, 23);
            this.mnuDictionaries.Text = "Справочники";
            //
            // mnuDistricts
            //
            this.mnuDistricts.Name = "mnuDistricts";
            this.mnuDistricts.Size = new System.Drawing.Size(220, 24);
            this.mnuDistricts.Text = "Районы";
            this.mnuDistricts.Click += new System.EventHandler(this.mnuDistricts_Click);
            //
            // mnuStreets
            //
            this.mnuStreets.Name = "mnuStreets";
            this.mnuStreets.Size = new System.Drawing.Size(220, 24);
            this.mnuStreets.Text = "Улицы";
            this.mnuStreets.Click += new System.EventHandler(this.mnuStreets_Click);
            //
            // mnuTypes
            //
            this.mnuTypes.Name = "mnuTypes";
            this.mnuTypes.Size = new System.Drawing.Size(220, 24);
            this.mnuTypes.Text = "Типы аварий";
            this.mnuTypes.Click += new System.EventHandler(this.mnuTypes_Click);
            //
            // mnuBrigades
            //
            this.mnuBrigades.Name = "mnuBrigades";
            this.mnuBrigades.Size = new System.Drawing.Size(220, 24);
            this.mnuBrigades.Text = "Бригады";
            this.mnuBrigades.Click += new System.EventHandler(this.mnuBrigades_Click);
            //
            // mnuEmployees
            //
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(220, 24);
            this.mnuEmployees.Text = "Сотрудники";
            this.mnuEmployees.Click += new System.EventHandler(this.mnuEmployees_Click);
            //
            // mnuMaterials
            //
            this.mnuMaterials.Name = "mnuMaterials";
            this.mnuMaterials.Size = new System.Drawing.Size(220, 24);
            this.mnuMaterials.Text = "Материалы";
            this.mnuMaterials.Click += new System.EventHandler(this.mnuMaterials_Click);
            //
            // mnuSeparator
            //
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(217, 6);
            //
            // mnuUsers
            //
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(220, 24);
            this.mnuUsers.Text = "Пользователи";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            //
            // mnuReports
            //
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(71, 23);
            this.mnuReports.Text = "Отчёты";
            this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
            //
            // mnuHelp
            //
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(72, 23);
            this.mnuHelp.Text = "Справка";
            //
            // mnuAbout
            //
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 24);
            this.mnuAbout.Text = "О программе";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 27);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 54);
            this.pnlHeader.TabIndex = 1;
            //
            // lblUser
            //
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(760, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(425, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Пользователь";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(520, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Аварийно-диспетчерская служба «Водоканал-Сервис»";
            //
            // pnlFilter
            //
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlFilter.Controls.Add(this.btnOpen);
            this.pnlFilter.Controls.Add(this.btnNew);
            this.pnlFilter.Controls.Add(this.btnReset);
            this.pnlFilter.Controls.Add(this.btnFind);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.cmbDistrict);
            this.pnlFilter.Controls.Add(this.lblDistrict);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 81);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1200, 92);
            this.pnlFilter.TabIndex = 2;
            //
            // btnOpen
            //
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(1030, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(155, 32);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Открыть заявку";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            //
            // btnNew
            //
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(1030, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 32);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "+ Новая заявка";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            //
            // btnReset
            //
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(625, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // btnFind
            //
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(505, 50);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 30);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(80, 53);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(405, 25);
            this.txtSearch.TabIndex = 9;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 19);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Поиск:";
            //
            // dtpTo
            //
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(745, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(130, 25);
            this.dtpTo.TabIndex = 7;
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(715, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 19);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "по";
            //
            // dtpFrom
            //
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(575, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 25);
            this.dtpFrom.TabIndex = 5;
            //
            // lblFrom
            //
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(505, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(66, 19);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "Период с";
            //
            // cmbDistrict
            //
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.Location = new System.Drawing.Point(305, 14);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(180, 25);
            this.cmbDistrict.TabIndex = 3;
            //
            // lblDistrict
            //
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(248, 18);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(51, 19);
            this.lblDistrict.TabIndex = 2;
            this.lblDistrict.Text = "Район:";
            //
            // cmbStatus
            //
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(80, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 25);
            this.cmbStatus.TabIndex = 1;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус:";
            //
            // dgvRequests
            //
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.EnableHeadersVisualStyles = false;
            this.dgvRequests.Location = new System.Drawing.Point(0, 173);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(1200, 501);
            this.dgvRequests.TabIndex = 3;
            this.dgvRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellDoubleClick);
            this.dgvRequests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRequests_CellFormatting);
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount,
            this.lblLegend});
            this.statusStrip.Location = new System.Drawing.Point(0, 674);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip.TabIndex = 4;
            //
            // lblCount
            //
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 21);
            this.lblCount.Text = "Заявок: 0";
            //
            // lblLegend
            //
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(1115, 21);
            this.lblLegend.Spring = true;
            this.lblLegend.Text = "Красный — просрочен норматив, жёлтый — новая, голубой — в работе";
            this.lblLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // MainForm
            //
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АДС «Водоканал-Сервис» — заявки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRequests;
        private System.Windows.Forms.ToolStripMenuItem mnuNewRequest;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenRequest;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuDictionaries;
        private System.Windows.Forms.ToolStripMenuItem mnuDistricts;
        private System.Windows.Forms.ToolStripMenuItem mnuStreets;
        private System.Windows.Forms.ToolStripMenuItem mnuTypes;
        private System.Windows.Forms.ToolStripMenuItem mnuBrigades;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterials;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel lblLegend;
    }
}
