namespace DC305RoomManagement
{
    partial class IssueManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.cbRoomName = new System.Windows.Forms.ComboBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.btnCreateIssue = new System.Windows.Forms.Button();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.IssueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIssueStatusValue = new System.Windows.Forms.ComboBox();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.txtIssueNameValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.label1);
            this.pnlMainContent.Controls.Add(this.dtpTo);
            this.pnlMainContent.Controls.Add(this.dtpFrom);
            this.pnlMainContent.Controls.Add(this.lblDateTo);
            this.pnlMainContent.Controls.Add(this.lblDateFrom);
            this.pnlMainContent.Controls.Add(this.cbRoomName);
            this.pnlMainContent.Controls.Add(this.lblRoomName);
            this.pnlMainContent.Controls.Add(this.btnPrint);
            this.pnlMainContent.Controls.Add(this.btnFilterDate);
            this.pnlMainContent.Controls.Add(this.btnCreateIssue);
            this.pnlMainContent.Controls.Add(this.dgvIssues);
            this.pnlMainContent.Controls.Add(this.cbIssueStatusValue);
            this.pnlMainContent.Controls.Add(this.lblIssueStatus);
            this.pnlMainContent.Controls.Add(this.lblIssueTitle);
            this.pnlMainContent.Controls.Add(this.txtIssueNameValue);
            this.pnlMainContent.Controls.Add(this.lblDescription);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(829, 479);
            this.pnlMainContent.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(526, 31);
            this.dtpTo.MinDate = new System.DateTime(2019, 8, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(102, 23);
            this.dtpTo.TabIndex = 13;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(375, 32);
            this.dtpFrom.MinDate = new System.DateTime(2019, 8, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(102, 23);
            this.dtpFrom.TabIndex = 13;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(494, 31);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(26, 17);
            this.lblDateTo.TabIndex = 12;
            this.lblDateTo.Text = "To:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(325, 32);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(44, 17);
            this.lblDateFrom.TabIndex = 12;
            this.lblDateFrom.Text = "From:";
            // 
            // cbRoomName
            // 
            this.cbRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomName.FormattingEnabled = true;
            this.cbRoomName.Location = new System.Drawing.Point(17, 29);
            this.cbRoomName.Name = "cbRoomName";
            this.cbRoomName.Size = new System.Drawing.Size(259, 25);
            this.cbRoomName.TabIndex = 11;
            this.cbRoomName.Validating += new System.ComponentModel.CancelEventHandler(this.IssueManager_Validating);
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(14, 9);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(47, 17);
            this.lblRoomName.TabIndex = 10;
            this.lblRoomName.Text = "Room";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(725, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            this.btnPrint.MouseEnter += new System.EventHandler(this.BtnPrint_MouseEnter);
            this.btnPrint.MouseLeave += new System.EventHandler(this.BtnPrint_MouseLeave);
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFilterDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnFilterDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDate.Location = new System.Drawing.Point(634, 29);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(85, 27);
            this.btnFilterDate.TabIndex = 9;
            this.btnFilterDate.Text = "Filter";
            this.btnFilterDate.UseVisualStyleBackColor = false;
            this.btnFilterDate.Click += new System.EventHandler(this.BtnFilterDate_Click);
            this.btnFilterDate.MouseEnter += new System.EventHandler(this.BtnFilterDate_MouseEnter);
            this.btnFilterDate.MouseLeave += new System.EventHandler(this.BtnFilterDate_MouseLeave);
            // 
            // btnCreateIssue
            // 
            this.btnCreateIssue.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreateIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateIssue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIssue.Location = new System.Drawing.Point(17, 226);
            this.btnCreateIssue.Name = "btnCreateIssue";
            this.btnCreateIssue.Size = new System.Drawing.Size(260, 32);
            this.btnCreateIssue.TabIndex = 9;
            this.btnCreateIssue.Text = "Save";
            this.btnCreateIssue.UseVisualStyleBackColor = false;
            this.btnCreateIssue.Click += new System.EventHandler(this.BtnSaveIssue_Click);
            this.btnCreateIssue.MouseEnter += new System.EventHandler(this.BtnCreateIssue_MouseEnter);
            this.btnCreateIssue.MouseLeave += new System.EventHandler(this.BtnCreateIssue_MouseLeave);
            // 
            // dgvIssues
            // 
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssues.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssues.ColumnHeadersHeight = 30;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueId,
            this.IssueName,
            this.Room,
            this.Description,
            this.Status,
            this.CreatedAt,
            this.ClosedAt});
            this.dgvIssues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIssues.EnableHeadersVisualStyles = false;
            this.dgvIssues.GridColor = System.Drawing.Color.Black;
            this.dgvIssues.Location = new System.Drawing.Point(17, 264);
            this.dgvIssues.Name = "dgvIssues";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssues.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIssues.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssues.Size = new System.Drawing.Size(800, 183);
            this.dgvIssues.TabIndex = 8;
            this.dgvIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIssues_CellDoubleClick);
            // 
            // IssueId
            // 
            this.IssueId.DataPropertyName = "IssueId";
            this.IssueId.HeaderText = "IssueID";
            this.IssueId.MinimumWidth = 65;
            this.IssueId.Name = "IssueId";
            // 
            // IssueName
            // 
            this.IssueName.DataPropertyName = "IssueName";
            this.IssueName.HeaderText = "Issue Title";
            this.IssueName.Name = "IssueName";
            // 
            // Room
            // 
            this.Room.DataPropertyName = "RoomId";
            this.Room.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created Date";
            this.CreatedAt.Name = "CreatedAt";
            // 
            // ClosedAt
            // 
            this.ClosedAt.DataPropertyName = "ClosedAt";
            this.ClosedAt.HeaderText = "Closed Date";
            this.ClosedAt.Name = "ClosedAt";
            // 
            // cbIssueStatusValue
            // 
            this.cbIssueStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssueStatusValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIssueStatusValue.FormattingEnabled = true;
            this.cbIssueStatusValue.Items.AddRange(new object[] {
            "Initiated",
            "In Work",
            "Fixed"});
            this.cbIssueStatusValue.Location = new System.Drawing.Point(18, 195);
            this.cbIssueStatusValue.Name = "cbIssueStatusValue";
            this.cbIssueStatusValue.Size = new System.Drawing.Size(259, 25);
            this.cbIssueStatusValue.TabIndex = 7;
            this.cbIssueStatusValue.Validating += new System.ComponentModel.CancelEventHandler(this.IssueManager_Validating);
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueStatus.Location = new System.Drawing.Point(15, 175);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(46, 17);
            this.lblIssueStatus.TabIndex = 2;
            this.lblIssueStatus.Text = "Status";
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueTitle.Location = new System.Drawing.Point(14, 57);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(32, 17);
            this.lblIssueTitle.TabIndex = 2;
            this.lblIssueTitle.Text = "Title";
            // 
            // txtIssueNameValue
            // 
            this.txtIssueNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueNameValue.Location = new System.Drawing.Point(17, 76);
            this.txtIssueNameValue.Name = "txtIssueNameValue";
            this.txtIssueNameValue.Size = new System.Drawing.Size(259, 23);
            this.txtIssueNameValue.TabIndex = 5;
            this.txtIssueNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.IssueManager_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionValue.Location = new System.Drawing.Point(17, 121);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 51);
            this.txtDescriptionValue.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Filter Date:";
            // 
            // IssueManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 479);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "IssueManager";
            this.Text = "Issue Manager";
            this.Load += new System.EventHandler(this.IssueManager_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.TextBox txtIssueNameValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblIssueStatus;
        private System.Windows.Forms.ComboBox cbIssueStatusValue;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.Button btnCreateIssue;
        private System.Windows.Forms.ComboBox cbRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedAt;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
    }
}