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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.gbLevels = new System.Windows.Forms.GroupBox();
            this.rbLevel7 = new System.Windows.Forms.RadioButton();
            this.rbLevel6 = new System.Windows.Forms.RadioButton();
            this.rbLevel5 = new System.Windows.Forms.RadioButton();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lbICourseName = new System.Windows.Forms.Label();
            this.txtCourseNameValue = new System.Windows.Forms.TextBox();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContent.SuspendLayout();
            this.gbLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.txtDuration);
            this.pnlMainContent.Controls.Add(this.gbLevels);
            this.pnlMainContent.Controls.Add(this.btnResetData);
            this.pnlMainContent.Controls.Add(this.btnSave);
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
            this.pnlMainContent.Size = new System.Drawing.Size(853, 393);
            this.pnlMainContent.TabIndex = 2;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(15, 185);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(259, 23);
            this.txtDuration.TabIndex = 13;
            // 
            // gbLevels
            // 
            this.gbLevels.Controls.Add(this.rbLevel7);
            this.gbLevels.Controls.Add(this.rbLevel6);
            this.gbLevels.Controls.Add(this.rbLevel5);
            this.gbLevels.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevels.Location = new System.Drawing.Point(15, 232);
            this.gbLevels.Name = "gbLevels";
            this.gbLevels.Size = new System.Drawing.Size(259, 56);
            this.gbLevels.TabIndex = 12;
            this.gbLevels.TabStop = false;
            this.gbLevels.Text = "Levels";
            // 
            // rbLevel7
            // 
            this.rbLevel7.AutoSize = true;
            this.rbLevel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLevel7.Location = new System.Drawing.Point(183, 21);
            this.rbLevel7.Name = "rbLevel7";
            this.rbLevel7.Size = new System.Drawing.Size(70, 21);
            this.rbLevel7.TabIndex = 0;
            this.rbLevel7.TabStop = true;
            this.rbLevel7.Text = "Level 7";
            this.rbLevel7.UseVisualStyleBackColor = true;
            // 
            // rbLevel6
            // 
            this.rbLevel6.AutoSize = true;
            this.rbLevel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLevel6.Location = new System.Drawing.Point(95, 21);
            this.rbLevel6.Name = "rbLevel6";
            this.rbLevel6.Size = new System.Drawing.Size(70, 21);
            this.rbLevel6.TabIndex = 0;
            this.rbLevel6.TabStop = true;
            this.rbLevel6.Text = "Level 6";
            this.rbLevel6.UseVisualStyleBackColor = true;
            // 
            // rbLevel5
            // 
            this.rbLevel5.AutoSize = true;
            this.rbLevel5.Checked = true;
            this.rbLevel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLevel5.Location = new System.Drawing.Point(7, 22);
            this.rbLevel5.Name = "rbLevel5";
            this.rbLevel5.Size = new System.Drawing.Size(70, 21);
            this.rbLevel5.TabIndex = 0;
            this.rbLevel5.TabStop = true;
            this.rbLevel5.Text = "Level 5";
            this.rbLevel5.UseVisualStyleBackColor = true;
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(152, 306);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(105, 30);
            this.btnResetData.TabIndex = 9;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            this.btnResetData.MouseEnter += new System.EventHandler(this.BtnResetData_MouseEnter);
            this.btnResetData.MouseLeave += new System.EventHandler(this.BtnResetData_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(27, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.BtnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.BtnSave_MouseLeave);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.ColumnHeadersHeight = 30;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Description,
            this.Duration,
            this.Level});
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.GridColor = System.Drawing.Color.Black;
            this.dgvCourses.Location = new System.Drawing.Point(296, 28);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(545, 308);
            this.dgvCourses.TabIndex = 8;
            this.dgvCourses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCourses_CellDoubleClick);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(12, 166);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 17);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            // 
            // lbICourseName
            // 
            this.lbICourseName.AutoSize = true;
            this.lbICourseName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbICourseName.Location = new System.Drawing.Point(12, 9);
            this.lbICourseName.Name = "lbICourseName";
            this.lbICourseName.Size = new System.Drawing.Size(97, 17);
            this.lbICourseName.TabIndex = 2;
            this.lbICourseName.Text = "Course Name";
            // 
            // txtCourseNameValue
            // 
            this.txtCourseNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNameValue.Location = new System.Drawing.Point(15, 28);
            this.txtCourseNameValue.Name = "txtCourseNameValue";
            this.txtCourseNameValue.Size = new System.Drawing.Size(259, 23);
            this.txtCourseNameValue.TabIndex = 5;
            this.txtCourseNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.CourseManager_Validating);
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDescription.Location = new System.Drawing.Point(12, 62);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(129, 17);
            this.lblCourseDescription.TabIndex = 3;
            this.lblCourseDescription.Text = "Course Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 81);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 72);
            this.txtDescriptionValue.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.FillWeight = 121.8274F;
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 92.7242F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 92.7242F;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.FillWeight = 92.7242F;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // CourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 393);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "CourseManager";
            this.Text = "Course Manager";
            this.Load += new System.EventHandler(this.CourseManager_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.gbLevels.ResumeLayout(false);
            this.gbLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lbICourseName;
        private System.Windows.Forms.TextBox txtCourseNameValue;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.GroupBox gbLevels;
        private System.Windows.Forms.RadioButton rbLevel7;
        private System.Windows.Forms.RadioButton rbLevel6;
        private System.Windows.Forms.RadioButton rbLevel5;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}