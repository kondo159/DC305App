namespace DC305RoomManagement
{
    partial class CourseManager
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lbICourseName = new System.Windows.Forms.Label();
            this.txtCourseNameValue = new System.Windows.Forms.TextBox();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.gbLevels = new System.Windows.Forms.GroupBox();
            this.rbLevel5 = new System.Windows.Forms.RadioButton();
            this.rbLevel6 = new System.Windows.Forms.RadioButton();
            this.rbLevel7 = new System.Windows.Forms.RadioButton();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gbLevels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.gbLevels);
            this.pnlMainContent.Controls.Add(this.cbDuration);
            this.pnlMainContent.Controls.Add(this.btnAdd);
            this.pnlMainContent.Controls.Add(this.btnUpdate);
            this.pnlMainContent.Controls.Add(this.dgvCourses);
            this.pnlMainContent.Controls.Add(this.lblDuration);
            this.pnlMainContent.Controls.Add(this.lbICourseName);
            this.pnlMainContent.Controls.Add(this.txtCourseNameValue);
            this.pnlMainContent.Controls.Add(this.lblCourseDescription);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(763, 393);
            this.pnlMainContent.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(324, 39);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(418, 337);
            this.dgvCourses.TabIndex = 8;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 203);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(58, 16);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            // 
            // lbICourseName
            // 
            this.lbICourseName.AutoSize = true;
            this.lbICourseName.Location = new System.Drawing.Point(12, 20);
            this.lbICourseName.Name = "lbICourseName";
            this.lbICourseName.Size = new System.Drawing.Size(91, 16);
            this.lbICourseName.TabIndex = 2;
            this.lbICourseName.Text = "Course Name";
            // 
            // txtCourseNameValue
            // 
            this.txtCourseNameValue.Location = new System.Drawing.Point(15, 39);
            this.txtCourseNameValue.Name = "txtCourseNameValue";
            this.txtCourseNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtCourseNameValue.TabIndex = 5;
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Location = new System.Drawing.Point(12, 86);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(122, 16);
            this.lblCourseDescription.TabIndex = 3;
            this.lblCourseDescription.Text = "Course Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 105);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 72);
            this.txtDescriptionValue.TabIndex = 6;
            // 
            // cbDuration
            // 
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(15, 223);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(259, 24);
            this.cbDuration.TabIndex = 11;
            // 
            // gbLevels
            // 
            this.gbLevels.Controls.Add(this.rbLevel7);
            this.gbLevels.Controls.Add(this.rbLevel6);
            this.gbLevels.Controls.Add(this.rbLevel5);
            this.gbLevels.Location = new System.Drawing.Point(15, 274);
            this.gbLevels.Name = "gbLevels";
            this.gbLevels.Size = new System.Drawing.Size(259, 56);
            this.gbLevels.TabIndex = 12;
            this.gbLevels.TabStop = false;
            this.gbLevels.Text = "Levels";
            // 
            // rbLevel5
            // 
            this.rbLevel5.AutoSize = true;
            this.rbLevel5.Checked = true;
            this.rbLevel5.Location = new System.Drawing.Point(7, 22);
            this.rbLevel5.Name = "rbLevel5";
            this.rbLevel5.Size = new System.Drawing.Size(69, 20);
            this.rbLevel5.TabIndex = 0;
            this.rbLevel5.TabStop = true;
            this.rbLevel5.Text = "Level 5";
            this.rbLevel5.UseVisualStyleBackColor = true;
            // 
            // rbLevel6
            // 
            this.rbLevel6.AutoSize = true;
            this.rbLevel6.Location = new System.Drawing.Point(95, 21);
            this.rbLevel6.Name = "rbLevel6";
            this.rbLevel6.Size = new System.Drawing.Size(69, 20);
            this.rbLevel6.TabIndex = 0;
            this.rbLevel6.TabStop = true;
            this.rbLevel6.Text = "Level 6";
            this.rbLevel6.UseVisualStyleBackColor = true;
            // 
            // rbLevel7
            // 
            this.rbLevel7.AutoSize = true;
            this.rbLevel7.Location = new System.Drawing.Point(183, 21);
            this.rbLevel7.Name = "rbLevel7";
            this.rbLevel7.Size = new System.Drawing.Size(69, 20);
            this.rbLevel7.TabIndex = 0;
            this.rbLevel7.TabStop = true;
            this.rbLevel7.Text = "Level 7";
            this.rbLevel7.UseVisualStyleBackColor = true;
            // 
            // CourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 393);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "CourseManager";
            this.Text = "Course Manager";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gbLevels.ResumeLayout(false);
            this.gbLevels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lbICourseName;
        private System.Windows.Forms.TextBox txtCourseNameValue;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.GroupBox gbLevels;
        private System.Windows.Forms.RadioButton rbLevel7;
        private System.Windows.Forms.RadioButton rbLevel6;
        private System.Windows.Forms.RadioButton rbLevel5;
    }
}