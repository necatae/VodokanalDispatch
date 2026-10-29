namespace VodokanalDispatch
{
    partial class DictionaryForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvData
            //
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(800, 410);
            this.dgvData.TabIndex = 0;
            this.dgvData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvData_DataError);
            this.dgvData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvData_UserDeletingRow);
            //
            // pnlBottom
            //
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlBottom.Controls.Add(this.lblCount);
            this.pnlBottom.Controls.Add(this.lblHint);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 410);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 70);
            this.pnlBottom.TabIndex = 1;
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 38);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 19);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Записей: 0";
            //
            // lblHint
            //
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(12, 12);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(470, 19);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Новая запись — в последней строке. Удаление — выделить строку и нажать Delete.";
            //
            // btnClose
            //
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(668, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // btnSave
            //
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(538, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // DictionaryForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "DictionaryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryForm_FormClosing);
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}
