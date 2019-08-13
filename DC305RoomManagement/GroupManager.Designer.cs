namespace DC305RoomManagement
{
    partial class GroupManager
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
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.lblMembers = new System.Windows.Forms.Label();
            this.txtGroupNameValue = new System.Windows.Forms.TextBox();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtNotesValue = new System.Windows.Forms.TextBox();
            this.lblGroupList = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnResetData);
            this.pnlMainContent.Controls.Add(this.dgvMemberList);
            this.pnlMainContent.Controls.Add(this.btnUpdateGroup);
            this.pnlMainContent.Controls.Add(this.lblGroupName);
            this.pnlMainContent.Controls.Add(this.btnSaveGroup);
            this.pnlMainContent.Controls.Add(this.lblMembers);
            this.pnlMainContent.Controls.Add(this.txtGroupNameValue);
            this.pnlMainContent.Controls.Add(this.dgvGroupList);
            this.pnlMainContent.Controls.Add(this.lblNotes);
            this.pnlMainContent.Controls.Add(this.btnAddMember);
            this.pnlMainContent.Controls.Add(this.txtNotesValue);
            this.pnlMainContent.Controls.Add(this.lblGroupList);
            this.pnlMainContent.Controls.Add(this.btnRemoveMember);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(642, 421);
            this.pnlMainContent.TabIndex = 5;
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(185, 362);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(75, 23);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(299, 245);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.Size = new System.Drawing.Size(319, 155);
            this.dgvMemberList.TabIndex = 2;
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(104, 362);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGroup.TabIndex = 0;
            this.btnUpdateGroup.Text = "Update";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 22);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(85, 16);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group Name";
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Location = new System.Drawing.Point(23, 362);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGroup.TabIndex = 0;
            this.btnSaveGroup.Text = "Save";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(296, 226);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(65, 16);
            this.lblMembers.TabIndex = 0;
            this.lblMembers.Text = "Members";
            // 
            // txtGroupNameValue
            // 
            this.txtGroupNameValue.Location = new System.Drawing.Point(15, 41);
            this.txtGroupNameValue.Name = "txtGroupNameValue";
            this.txtGroupNameValue.Size = new System.Drawing.Size(209, 22);
            this.txtGroupNameValue.TabIndex = 1;
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Location = new System.Drawing.Point(299, 41);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.Size = new System.Drawing.Size(319, 155);
            this.dgvGroupList.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 86);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(44, 16);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(462, 219);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // txtNotesValue
            // 
            this.txtNotesValue.Location = new System.Drawing.Point(15, 105);
            this.txtNotesValue.Multiline = true;
            this.txtNotesValue.Name = "txtNotesValue";
            this.txtNotesValue.Size = new System.Drawing.Size(259, 232);
            this.txtNotesValue.TabIndex = 1;
            // 
            // lblGroupList
            // 
            this.lblGroupList.AutoSize = true;
            this.lblGroupList.Location = new System.Drawing.Point(296, 22);
            this.lblGroupList.Name = "lblGroupList";
            this.lblGroupList.Size = new System.Drawing.Size(52, 16);
            this.lblGroupList.TabIndex = 0;
            this.lblGroupList.Text = "Groups";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(543, 219);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMember.TabIndex = 3;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            // 
            // GroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 421);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "GroupManager";
            this.Text = "Group Manager";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.TextBox txtGroupNameValue;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtNotesValue;
        private System.Windows.Forms.Label lblGroupList;
        private System.Windows.Forms.Button btnRemoveMember;
    }
}