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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 25);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 287);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 25);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Student"});
            this.cboRole.Location = new System.Drawing.Point(12, 344);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(193, 25);
            this.cboRole.TabIndex = 10;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.CboRole_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 395);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 38);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(146, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(280, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 38);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.Location = new System.Drawing.Point(414, 395);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(128, 38);
            this.btnDisable.TabIndex = 15;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // dtgGrid
            // 
            this.dtgGrid.AllowUserToAddRows = false;
            this.dtgGrid.AllowUserToDeleteRows = false;
            this.dtgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgGrid.ColumnHeadersHeight = 28;
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgGrid.Location = new System.Drawing.Point(218, 84);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            this.dtgGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgGrid.Size = new System.Drawing.Size(607, 285);
            this.dtgGrid.TabIndex = 16;
            this.dtgGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgGrid_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(218, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 25);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "yyyy-MM-dd";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(56, 182);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(95, 20);
            this.dtDOB.TabIndex = 18;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(12, 188);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "DOB";
            this.lblDOB.Click += new System.EventHandler(this.LblDOB_Click);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(11, 25);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 19;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.RbtnMale_CheckedChanged);
            this.rbtnMale.Validating += new System.ComponentModel.CancelEventHandler(this.RbtnMale_Validating);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(80, 25);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
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
            this.grpGender.Location = new System.Drawing.Point(12, 127);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 48);
            this.grpGender.TabIndex = 23;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Search by Name or Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "UserID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 38);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(41, 20);
            this.txtID.TabIndex = 24;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
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
            this.MaximizeBox = false;
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
    }
}