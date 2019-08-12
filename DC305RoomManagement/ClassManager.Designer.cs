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
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lbIClassName = new System.Windows.Forms.Label();
            this.txtCourseTitleValue = new System.Windows.Forms.TextBox();
            this.txtClassNameValue = new System.Windows.Forms.TextBox();
            this.lblGroupOfStudents = new System.Windows.Forms.Label();
            this.txtStaffNameValue = new System.Windows.Forms.TextBox();
            this.txtGroupOfStudentsValue = new System.Windows.Forms.TextBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnAddGroup);
            this.pnlMainContent.Controls.Add(this.btnDeleteGroup);
            this.pnlMainContent.Controls.Add(this.btnCreate);
            this.pnlMainContent.Controls.Add(this.btnUpdate);
            this.pnlMainContent.Controls.Add(this.dgvInventory);
            this.pnlMainContent.Controls.Add(this.lblStaff);
            this.pnlMainContent.Controls.Add(this.lblCourseTitle);
            this.pnlMainContent.Controls.Add(this.lbIClassName);
            this.pnlMainContent.Controls.Add(this.txtGroupOfStudentsValue);
            this.pnlMainContent.Controls.Add(this.txtStaffNameValue);
            this.pnlMainContent.Controls.Add(this.txtCourseTitleValue);
            this.pnlMainContent.Controls.Add(this.txtClassNameValue);
            this.pnlMainContent.Controls.Add(this.lblGroupOfStudents);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(764, 450);
            this.pnlMainContent.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(312, 396);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(324, 39);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(418, 325);
            this.dgvInventory.TabIndex = 8;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(15, 146);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(34, 16);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Staff";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(12, 83);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(80, 16);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title";
            // 
            // lbIClassName
            // 
            this.lbIClassName.AutoSize = true;
            this.lbIClassName.Location = new System.Drawing.Point(12, 20);
            this.lbIClassName.Name = "lbIClassName";
            this.lbIClassName.Size = new System.Drawing.Size(82, 16);
            this.lbIClassName.TabIndex = 2;
            this.lbIClassName.Text = "Class Name";
            // 
            // txtCourseTitleValue
            // 
            this.txtCourseTitleValue.Location = new System.Drawing.Point(15, 102);
            this.txtCourseTitleValue.Name = "txtCourseTitleValue";
            this.txtCourseTitleValue.Size = new System.Drawing.Size(259, 22);
            this.txtCourseTitleValue.TabIndex = 5;
            // 
            // txtClassNameValue
            // 
            this.txtClassNameValue.Location = new System.Drawing.Point(15, 39);
            this.txtClassNameValue.Name = "txtClassNameValue";
            this.txtClassNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtClassNameValue.TabIndex = 5;
            // 
            // lblGroupOfStudents
            // 
            this.lblGroupOfStudents.AutoSize = true;
            this.lblGroupOfStudents.Location = new System.Drawing.Point(12, 214);
            this.lblGroupOfStudents.Name = "lblGroupOfStudents";
            this.lblGroupOfStudents.Size = new System.Drawing.Size(116, 16);
            this.lblGroupOfStudents.TabIndex = 3;
            this.lblGroupOfStudents.Text = "Group Of Students";
            // 
            // txtStaffNameValue
            // 
            this.txtStaffNameValue.Location = new System.Drawing.Point(15, 165);
            this.txtStaffNameValue.Name = "txtStaffNameValue";
            this.txtStaffNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtStaffNameValue.TabIndex = 5;
            // 
            // txtGroupOfStudentsValue
            // 
            this.txtGroupOfStudentsValue.Location = new System.Drawing.Point(15, 233);
            this.txtGroupOfStudentsValue.Multiline = true;
            this.txtGroupOfStudentsValue.Name = "txtGroupOfStudentsValue";
            this.txtGroupOfStudentsValue.Size = new System.Drawing.Size(259, 102);
            this.txtGroupOfStudentsValue.TabIndex = 5;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(199, 341);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGroup.TabIndex = 9;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(118, 341);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 9;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // ClassManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "ClassManager";
            this.Text = "Class Manager";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lbIClassName;
        private System.Windows.Forms.TextBox txtCourseTitleValue;
        private System.Windows.Forms.TextBox txtClassNameValue;
        private System.Windows.Forms.Label lblGroupOfStudents;
        private System.Windows.Forms.TextBox txtStaffNameValue;
        private System.Windows.Forms.TextBox txtGroupOfStudentsValue;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
    }
}