namespace DC305RoomManagement
{
    partial class ClassManager
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
            this.cbGroupNameValue = new System.Windows.Forms.ComboBox();
            this.cbStaffNameValue = new System.Windows.Forms.ComboBox();
            this.cbCourseTitleValue = new System.Windows.Forms.ComboBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lbIClassName = new System.Windows.Forms.Label();
            this.txtClassNameValue = new System.Windows.Forms.TextBox();
            this.lblGroupOfStudents = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.cbGroupNameValue);
            this.pnlMainContent.Controls.Add(this.cbStaffNameValue);
            this.pnlMainContent.Controls.Add(this.cbCourseTitleValue);
            this.pnlMainContent.Controls.Add(this.btnDeleteGroup);
            this.pnlMainContent.Controls.Add(this.btnReset);
            this.pnlMainContent.Controls.Add(this.btnCreate);
            this.pnlMainContent.Controls.Add(this.dgvClasses);
            this.pnlMainContent.Controls.Add(this.lblStaff);
            this.pnlMainContent.Controls.Add(this.lblCourseTitle);
            this.pnlMainContent.Controls.Add(this.lbIClassName);
            this.pnlMainContent.Controls.Add(this.txtClassNameValue);
            this.pnlMainContent.Controls.Add(this.lblGroupOfStudents);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(837, 465);
            this.pnlMainContent.TabIndex = 2;
            // 
            // cbGroupNameValue
            // 
            this.cbGroupNameValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupNameValue.FormattingEnabled = true;
            this.cbGroupNameValue.Location = new System.Drawing.Point(15, 202);
            this.cbGroupNameValue.Name = "cbGroupNameValue";
            this.cbGroupNameValue.Size = new System.Drawing.Size(259, 25);
            this.cbGroupNameValue.TabIndex = 10;
            // 
            // cbStaffNameValue
            // 
            this.cbStaffNameValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffNameValue.FormattingEnabled = true;
            this.cbStaffNameValue.Location = new System.Drawing.Point(15, 143);
            this.cbStaffNameValue.Name = "cbStaffNameValue";
            this.cbStaffNameValue.Size = new System.Drawing.Size(259, 25);
            this.cbStaffNameValue.TabIndex = 10;
            // 
            // cbCourseTitleValue
            // 
            this.cbCourseTitleValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseTitleValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourseTitleValue.FormattingEnabled = true;
            this.cbCourseTitleValue.Location = new System.Drawing.Point(15, 82);
            this.cbCourseTitleValue.Name = "cbCourseTitleValue";
            this.cbCourseTitleValue.Size = new System.Drawing.Size(259, 25);
            this.cbCourseTitleValue.TabIndex = 10;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroup.Location = new System.Drawing.Point(111, 245);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteGroup.TabIndex = 9;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.MouseEnter += new System.EventHandler(this.BtnDeleteGroup_MouseEnter);
            this.btnDeleteGroup.MouseLeave += new System.EventHandler(this.BtnDeleteGroup_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(201, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnResetData_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.BtnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.BtnReset_MouseLeave);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(17, 245);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.BtnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.ColumnHeadersHeight = 30;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.Course,
            this.Staff,
            this.Group});
            this.dgvClasses.EnableHeadersVisualStyles = false;
            this.dgvClasses.GridColor = System.Drawing.Color.Black;
            this.dgvClasses.Location = new System.Drawing.Point(314, 28);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClasses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClasses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(504, 368);
            this.dgvClasses.TabIndex = 8;
            this.dgvClasses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClasses_CellDoubleClick);
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "CourseID";
            this.Course.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Staff
            // 
            this.Staff.DataPropertyName = "StaffID";
            this.Staff.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Staff.HeaderText = "Staff";
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "GroupID";
            this.Group.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(12, 124);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(36, 17);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Staff";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(12, 63);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(81, 17);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title";
            // 
            // lbIClassName
            // 
            this.lbIClassName.AutoSize = true;
            this.lbIClassName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIClassName.Location = new System.Drawing.Point(12, 9);
            this.lbIClassName.Name = "lbIClassName";
            this.lbIClassName.Size = new System.Drawing.Size(85, 17);
            this.lbIClassName.TabIndex = 2;
            this.lbIClassName.Text = "Class Name";
            // 
            // txtClassNameValue
            // 
            this.txtClassNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassNameValue.Location = new System.Drawing.Point(15, 28);
            this.txtClassNameValue.Name = "txtClassNameValue";
            this.txtClassNameValue.Size = new System.Drawing.Size(259, 23);
            this.txtClassNameValue.TabIndex = 5;
            this.txtClassNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.ClassManager_Validating);
            // 
            // lblGroupOfStudents
            // 
            this.lblGroupOfStudents.AutoSize = true;
            this.lblGroupOfStudents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupOfStudents.Location = new System.Drawing.Point(12, 183);
            this.lblGroupOfStudents.Name = "lblGroupOfStudents";
            this.lblGroupOfStudents.Size = new System.Drawing.Size(126, 17);
            this.lblGroupOfStudents.TabIndex = 3;
            this.lblGroupOfStudents.Text = "Group Of Students";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ClassManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "ClassManager";
            this.Text = "Class Manager";
            this.Load += new System.EventHandler(this.ClassManager_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lbIClassName;
        private System.Windows.Forms.TextBox txtClassNameValue;
        private System.Windows.Forms.Label lblGroupOfStudents;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.ComboBox cbGroupNameValue;
        private System.Windows.Forms.ComboBox cbStaffNameValue;
        private System.Windows.Forms.ComboBox cbCourseTitleValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Course;
        private System.Windows.Forms.DataGridViewComboBoxColumn Staff;
        private System.Windows.Forms.DataGridViewComboBoxColumn Group;
    }
}