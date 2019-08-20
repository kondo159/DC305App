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
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.cbRoomName = new System.Windows.Forms.ComboBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.btnCreateIssue = new System.Windows.Forms.Button();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.cbIssueStatusValue = new System.Windows.Forms.ComboBox();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.txtIssueNameValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.IssueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
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
            // cbRoomName
            // 
            this.cbRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomName.FormattingEnabled = true;
            this.cbRoomName.Location = new System.Drawing.Point(15, 40);
            this.cbRoomName.Name = "cbRoomName";
            this.cbRoomName.Size = new System.Drawing.Size(259, 24);
            this.cbRoomName.TabIndex = 11;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(12, 20);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(45, 16);
            this.lblRoomName.TabIndex = 10;
            this.lblRoomName.Text = "Room";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(713, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(627, 20);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(80, 23);
            this.btnFilterDate.TabIndex = 9;
            this.btnFilterDate.Text = "Filter Date";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            // 
            // btnCreateIssue
            // 
            this.btnCreateIssue.Location = new System.Drawing.Point(183, 432);
            this.btnCreateIssue.Name = "btnCreateIssue";
            this.btnCreateIssue.Size = new System.Drawing.Size(91, 23);
            this.btnCreateIssue.TabIndex = 9;
            this.btnCreateIssue.Text = "Save";
            this.btnCreateIssue.UseVisualStyleBackColor = true;
            this.btnCreateIssue.Click += new System.EventHandler(this.BtnSaveIssue_Click);
            // 
            // dgvIssues
            // 
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueId,
            this.IssueName,
            this.Room,
            this.Description,
            this.Status,
            this.CreatedAt,
            this.ClosedAt});
            this.dgvIssues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIssues.Location = new System.Drawing.Point(324, 49);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssues.Size = new System.Drawing.Size(493, 359);
            this.dgvIssues.TabIndex = 8;
            this.dgvIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIssues_CellContentClick);
            this.dgvIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIssues_CellDoubleClick);
            // 
            // cbIssueStatusValue
            // 
            this.cbIssueStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssueStatusValue.FormattingEnabled = true;
            this.cbIssueStatusValue.Items.AddRange(new object[] {
            "Initiated",
            "In Work",
            "Fixed"});
            this.cbIssueStatusValue.Location = new System.Drawing.Point(15, 384);
            this.cbIssueStatusValue.Name = "cbIssueStatusValue";
            this.cbIssueStatusValue.Size = new System.Drawing.Size(259, 24);
            this.cbIssueStatusValue.TabIndex = 7;
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.Location = new System.Drawing.Point(12, 364);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(45, 16);
            this.lblIssueStatus.TabIndex = 2;
            this.lblIssueStatus.Text = "Status";
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Location = new System.Drawing.Point(12, 83);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(34, 16);
            this.lblIssueTitle.TabIndex = 2;
            this.lblIssueTitle.Text = "Title";
            // 
            // txtIssueNameValue
            // 
            this.txtIssueNameValue.Location = new System.Drawing.Point(15, 102);
            this.txtIssueNameValue.Name = "txtIssueNameValue";
            this.txtIssueNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtIssueNameValue.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 142);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 161);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 185);
            this.txtDescriptionValue.TabIndex = 6;
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
            // IssueManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 479);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "IssueManager";
            this.Text = "Issue Manager";
            this.Load += new System.EventHandler(this.IssueManager_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
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
    }
}