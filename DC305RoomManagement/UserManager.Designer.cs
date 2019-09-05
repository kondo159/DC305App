namespace DC305RoomManagement
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(229, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 23);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(229, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(440, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(443, 34);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(193, 25);
            this.cboRole.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(12, 125);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 35);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.BtnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(139, 125);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.BtnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.BtnUpdate_MouseLeave_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(270, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 35);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.BtnReset_MouseEnter_1);
            this.btnReset.MouseLeave += new System.EventHandler(this.BtnReset_MouseLeave_1);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnDisable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.Black;
            this.btnDisable.Location = new System.Drawing.Point(401, 125);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(125, 35);
            this.btnDisable.TabIndex = 15;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            this.btnDisable.MouseEnter += new System.EventHandler(this.BtnDisable_MouseEnter);
            this.btnDisable.MouseLeave += new System.EventHandler(this.BtnDisable_MouseLeave);
            // 
            // dtgGrid
            // 
            this.dtgGrid.AllowUserToAddRows = false;
            this.dtgGrid.AllowUserToDeleteRows = false;
            this.dtgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGrid.ColumnHeadersHeight = 30;
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.NameC,
            this.DOB,
            this.Genders,
            this.Email,
            this.Password,
            this.RoleId,
            this.Role});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGrid.EnableHeadersVisualStyles = false;
            this.dtgGrid.GridColor = System.Drawing.Color.Black;
            this.dtgGrid.Location = new System.Drawing.Point(12, 166);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgGrid.Size = new System.Drawing.Size(813, 294);
            this.dtgGrid.TabIndex = 16;
            this.dtgGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgGrid_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(655, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 23);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "yyyy-MM-dd";
            this.dtDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(229, 86);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(193, 23);
            this.dtDOB.TabIndex = 18;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(226, 65);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(88, 17);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Date of Birth";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.ForeColor = System.Drawing.Color.Black;
            this.rbtnMale.Location = new System.Drawing.Point(11, 25);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(57, 21);
            this.rbtnMale.TabIndex = 19;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.RbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.ForeColor = System.Drawing.Color.Black;
            this.rbtnFemale.Location = new System.Drawing.Point(80, 25);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(73, 21);
            this.rbtnFemale.TabIndex = 20;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.RbtnFemale_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtnMale);
            this.grpGender.Controls.Add(this.rbtnFemale);
            this.grpGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.ForeColor = System.Drawing.Color.Black;
            this.grpGender.Location = new System.Drawing.Point(443, 65);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(190, 51);
            this.grpGender.TabIndex = 23;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(652, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Search by Name or Email";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(766, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 23);
            this.txtID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "(yyyy-mm-dd)";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // NameC
            // 
            this.NameC.DataPropertyName = "Name";
            this.NameC.FillWeight = 114.861F;
            this.NameC.HeaderText = "Name";
            this.NameC.Name = "NameC";
            this.NameC.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.FillWeight = 74.44115F;
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Genders
            // 
            this.Genders.DataPropertyName = "Gender";
            this.Genders.FillWeight = 115.1675F;
            this.Genders.HeaderText = "Gender";
            this.Genders.Name = "Genders";
            this.Genders.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 154.3872F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.FillWeight = 96.338F;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "Role";
            this.RoleId.HeaderText = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            this.RoleId.Visible = false;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleName";
            this.Role.FillWeight = 62.73388F;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgGrid);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.DataGridView dtgGrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}