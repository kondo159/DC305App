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
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.txtRoomNameValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.cbIssueStatusValue = new System.Windows.Forms.ComboBox();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.brnCreateIssue = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnPrint);
            this.pnlMainContent.Controls.Add(this.btnFilterDate);
            this.pnlMainContent.Controls.Add(this.btnUpdate);
            this.pnlMainContent.Controls.Add(this.brnCreateIssue);
            this.pnlMainContent.Controls.Add(this.dgvIssues);
            this.pnlMainContent.Controls.Add(this.cbIssueStatusValue);
            this.pnlMainContent.Controls.Add(this.lblIssueStatus);
            this.pnlMainContent.Controls.Add(this.lblIssueTitle);
            this.pnlMainContent.Controls.Add(this.txtRoomNameValue);
            this.pnlMainContent.Controls.Add(this.lblDescription);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(800, 450);
            this.pnlMainContent.TabIndex = 0;
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Location = new System.Drawing.Point(12, 20);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(34, 16);
            this.lblIssueTitle.TabIndex = 2;
            this.lblIssueTitle.Text = "Title";
            // 
            // txtRoomNameValue
            // 
            this.txtRoomNameValue.Location = new System.Drawing.Point(15, 39);
            this.txtRoomNameValue.Name = "txtRoomNameValue";
            this.txtRoomNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtRoomNameValue.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 103);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 185);
            this.txtDescriptionValue.TabIndex = 6;
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.Location = new System.Drawing.Point(12, 320);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(45, 16);
            this.lblIssueStatus.TabIndex = 2;
            this.lblIssueStatus.Text = "Status";
            // 
            // cbIssueStatusValue
            // 
            this.cbIssueStatusValue.FormattingEnabled = true;
            this.cbIssueStatusValue.Location = new System.Drawing.Point(15, 340);
            this.cbIssueStatusValue.Name = "cbIssueStatusValue";
            this.cbIssueStatusValue.Size = new System.Drawing.Size(259, 24);
            this.cbIssueStatusValue.TabIndex = 7;
            // 
            // dgvIssues
            // 
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(324, 39);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.Size = new System.Drawing.Size(418, 325);
            this.dgvIssues.TabIndex = 8;
            // 
            // brnCreateIssue
            // 
            this.brnCreateIssue.Location = new System.Drawing.Point(236, 394);
            this.brnCreateIssue.Name = "brnCreateIssue";
            this.brnCreateIssue.Size = new System.Drawing.Size(91, 23);
            this.brnCreateIssue.TabIndex = 9;
            this.brnCreateIssue.Text = "Create Issue";
            this.brnCreateIssue.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(414, 394);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(80, 23);
            this.btnFilterDate.TabIndex = 9;
            this.btnFilterDate.Text = "Filter Date";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(500, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // IssueManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "IssueManagerForm";
            this.Text = "Issue Manager";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.TextBox txtRoomNameValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblIssueStatus;
        private System.Windows.Forms.ComboBox cbIssueStatusValue;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button brnCreateIssue;
    }
}