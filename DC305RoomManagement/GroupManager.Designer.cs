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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupManager));
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
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
            this.pnlMainContent.Size = new System.Drawing.Size(838, 465);
            this.pnlMainContent.TabIndex = 5;
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(129, 249);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(92, 27);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            this.btnResetData.MouseEnter += new System.EventHandler(this.BtnResetData_MouseEnter);
            this.btnResetData.MouseLeave += new System.EventHandler(this.BtnResetData_MouseLeave);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.ColumnHeadersHeight = 30;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.UserId,
            this.UserName,
            this.DOB,
            this.Gender,
            this.Email,
            this.UserActive});
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.GridColor = System.Drawing.Color.Black;
            this.dgvMembers.Location = new System.Drawing.Point(240, 249);
            this.dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMembers.Size = new System.Drawing.Size(577, 204);
            this.dgvMembers.TabIndex = 2;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBox.Frozen = true;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 95;
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
            this.UserName.FillWeight = 135.4426F;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.FillWeight = 83.93744F;
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 83.93744F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 112.7451F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // UserActive
            // 
            this.UserActive.DataPropertyName = "Active";
            this.UserActive.FillWeight = 83.93744F;
            this.UserActive.HeaderText = "Active";
            this.UserActive.Name = "UserActive";
            this.UserActive.ReadOnly = true;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(93, 17);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group Name";
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGroup.Location = new System.Drawing.Point(15, 249);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(90, 27);
            this.btnSaveGroup.TabIndex = 0;
            this.btnSaveGroup.Text = "Save";
            this.btnSaveGroup.UseVisualStyleBackColor = false;
            this.btnSaveGroup.Click += new System.EventHandler(this.BtnSaveGroup_Click);
            this.btnSaveGroup.MouseEnter += new System.EventHandler(this.BtnSaveGroup_MouseEnter);
            this.btnSaveGroup.MouseLeave += new System.EventHandler(this.BtnSaveGroup_MouseLeave);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(236, 222);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(82, 21);
            this.lblMembers.TabIndex = 0;
            this.lblMembers.Text = "Members";
            // 
            // txtGroupNameValue
            // 
            this.txtGroupNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNameValue.Location = new System.Drawing.Point(15, 28);
            this.txtGroupNameValue.Name = "txtGroupNameValue";
            this.txtGroupNameValue.Size = new System.Drawing.Size(206, 23);
            this.txtGroupNameValue.TabIndex = 1;
            this.txtGroupNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.GroupManager_Validating);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroups.ColumnHeadersHeight = 30;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName,
            this.Description,
            this.Active});
            this.dgvGroups.EnableHeadersVisualStyles = false;
            this.dgvGroups.GridColor = System.Drawing.Color.Black;
            this.dgvGroups.Location = new System.Drawing.Point(244, 58);
            this.dgvGroups.Name = "dgvGroups";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroups.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(573, 152);
            this.dgvGroups.TabIndex = 2;
            this.dgvGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroupList_CellDoubleClick);
            this.dgvGroups.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroups_CellValueChanged);
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.DgvGroups_SelectionChanged);
            this.dgvGroups.MouseEnter += new System.EventHandler(this.DgvGroups_MouseEnter);
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
            this.lblNotes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(12, 53);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(651, 216);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(80, 27);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            this.btnAddMember.MouseEnter += new System.EventHandler(this.BtnAddMember_MouseEnter);
            this.btnAddMember.MouseLeave += new System.EventHandler(this.BtnAddMember_MouseLeave);
            // 
            // txtNotesValue
            // 
            this.txtNotesValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotesValue.Location = new System.Drawing.Point(15, 72);
            this.txtNotesValue.Multiline = true;
            this.txtNotesValue.Name = "txtNotesValue";
            this.txtNotesValue.Size = new System.Drawing.Size(206, 171);
            this.txtNotesValue.TabIndex = 1;
            // 
            // lblGroupList
            // 
            this.lblGroupList.AutoSize = true;
            this.lblGroupList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupList.Location = new System.Drawing.Point(242, 27);
            this.lblGroupList.Name = "lblGroupList";
            this.lblGroupList.Size = new System.Drawing.Size(66, 21);
            this.lblGroupList.TabIndex = 0;
            this.lblGroupList.Text = "Groups";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMember.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(737, 216);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(80, 27);
            this.btnRemoveMember.TabIndex = 3;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.BtnRemoveMember_Click);
            this.btnRemoveMember.MouseEnter += new System.EventHandler(this.BtnRemoveMember_MouseEnter);
            this.btnRemoveMember.MouseLeave += new System.EventHandler(this.BtnRemoveMember_MouseLeave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.pnlMainContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ErrorProvider errorProvider;
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
    }
}