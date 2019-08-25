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
            this.components = new System.ComponentModel.Container();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.lblMembers = new System.Windows.Forms.Label();
            this.txtGroupNameValue = new System.Windows.Forms.TextBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtNotesValue = new System.Windows.Forms.TextBox();
            this.lblGroupList = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnResetData);
            this.pnlMainContent.Controls.Add(this.dgvMembers);
            this.pnlMainContent.Controls.Add(this.lblGroupName);
            this.pnlMainContent.Controls.Add(this.btnSaveGroup);
            this.pnlMainContent.Controls.Add(this.lblMembers);
            this.pnlMainContent.Controls.Add(this.txtGroupNameValue);
            this.pnlMainContent.Controls.Add(this.dgvGroups);
            this.pnlMainContent.Controls.Add(this.lblNotes);
            this.pnlMainContent.Controls.Add(this.btnAddMember);
            this.pnlMainContent.Controls.Add(this.txtNotesValue);
            this.pnlMainContent.Controls.Add(this.lblGroupList);
            this.pnlMainContent.Controls.Add(this.btnRemoveMember);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(677, 421);
            this.pnlMainContent.TabIndex = 5;
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(150, 362);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(75, 23);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.UserId,
            this.UserName,
            this.DOB,
            this.Gender,
            this.Email,
            this.UserActive});
            this.dgvMembers.Location = new System.Drawing.Point(320, 245);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(340, 155);
            this.dgvMembers.TabIndex = 2;
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
            this.btnSaveGroup.Location = new System.Drawing.Point(56, 362);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGroup.TabIndex = 0;
            this.btnSaveGroup.Text = "Save";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            this.btnSaveGroup.Click += new System.EventHandler(this.BtnSaveGroup_Click);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(317, 226);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(65, 16);
            this.lblMembers.TabIndex = 0;
            this.lblMembers.Text = "Members";
            // 
            // txtGroupNameValue
            // 
            this.txtGroupNameValue.Location = new System.Drawing.Point(15, 41);
            this.txtGroupNameValue.Name = "txtGroupNameValue";
            this.txtGroupNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtGroupNameValue.TabIndex = 1;
            this.txtGroupNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.GroupManager_Validating);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName,
            this.Description,
            this.Active});
            this.dgvGroups.Location = new System.Drawing.Point(320, 41);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(340, 155);
            this.dgvGroups.TabIndex = 2;
            this.dgvGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroupList_CellDoubleClick);
            this.dgvGroups.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroups_CellValueChanged);
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.DgvGroups_SelectionChanged);
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.HeaderText = "GroupID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
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
            this.btnAddMember.Location = new System.Drawing.Point(483, 219);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
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
            this.lblGroupList.Location = new System.Drawing.Point(317, 22);
            this.lblGroupList.Name = "lblGroupList";
            this.lblGroupList.Size = new System.Drawing.Size(52, 16);
            this.lblGroupList.TabIndex = 0;
            this.lblGroupList.Text = "Groups";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(564, 219);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMember.TabIndex = 3;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.BtnRemoveMember_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.Frozen = true;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 50;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // UserActive
            // 
            this.UserActive.DataPropertyName = "Active";
            this.UserActive.HeaderText = "Active";
            this.UserActive.Name = "UserActive";
            this.UserActive.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "GroupManager";
            this.Text = "Group Manager";
            this.Load += new System.EventHandler(this.GroupManager_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.TextBox txtGroupNameValue;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtNotesValue;
        private System.Windows.Forms.Label lblGroupList;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserActive;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}