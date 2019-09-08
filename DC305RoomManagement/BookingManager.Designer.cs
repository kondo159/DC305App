namespace DC305RoomManagement
{
    partial class BookingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingManager));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.cboxStaff = new System.Windows.Forms.ComboBox();
            this.cboxRoom = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dgvBookingList = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDateTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoCUD = new System.Windows.Forms.RadioButton();
            this.rdoFilter = new System.Windows.Forms.RadioButton();
            this.cballdates = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.Location = new System.Drawing.Point(191, 167);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 35);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            this.btnPrint.MouseEnter += new System.EventHandler(this.BtnPrint_MouseEnter);
            this.btnPrint.MouseLeave += new System.EventHandler(this.BtnPrint_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnReset.Location = new System.Drawing.Point(318, 123);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 35);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.BtnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.BtnReset_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(318, 167);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.BtnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.BtnCancel_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUpdate.Location = new System.Drawing.Point(191, 124);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 35);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.BtnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.BtnUpdate_MouseLeave);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCreate.Location = new System.Drawing.Point(59, 124);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 35);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.BtnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Enabled = false;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFilter.Location = new System.Drawing.Point(59, 167);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 35);
            this.btnFilter.TabIndex = 29;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            this.btnFilter.MouseEnter += new System.EventHandler(this.BtnFilter_MouseEnter);
            this.btnFilter.MouseLeave += new System.EventHandler(this.BtnFilter_MouseLeave);
            // 
            // cboxClass
            // 
            this.cboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Location = new System.Drawing.Point(496, 124);
            this.cboxClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(259, 25);
            this.cboxClass.TabIndex = 28;
            // 
            // cboxStaff
            // 
            this.cboxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cboxStaff.FormattingEnabled = true;
            this.cboxStaff.Location = new System.Drawing.Point(496, 86);
            this.cboxStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxStaff.Name = "cboxStaff";
            this.cboxStaff.Size = new System.Drawing.Size(259, 25);
            this.cboxStaff.TabIndex = 27;
            // 
            // cboxRoom
            // 
            this.cboxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cboxRoom.FormattingEnabled = true;
            this.cboxRoom.Location = new System.Drawing.Point(496, 51);
            this.cboxRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxRoom.Name = "cboxRoom";
            this.cboxRoom.Size = new System.Drawing.Size(259, 25);
            this.cboxRoom.TabIndex = 26;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(445, 124);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(45, 17);
            this.lblClass.TabIndex = 25;
            this.lblClass.Text = "Class:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(428, 86);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(62, 17);
            this.lblTeacher.TabIndex = 24;
            this.lblTeacher.Text = "Teacher:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(435, 51);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(51, 17);
            this.lblRoom.TabIndex = 23;
            this.lblRoom.Text = "Room:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(74, 89);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(62, 17);
            this.lblToDate.TabIndex = 22;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(56, 53);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(80, 17);
            this.lblFromDate.TabIndex = 21;
            this.lblFromDate.Text = "From Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd MMMM yyyy hh:mm tt";
            this.dtpEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(142, 89);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(259, 23);
            this.dtpEnd.TabIndex = 20;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd MMMM yyyy hh:mm tt";
            this.dtpStart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(142, 53);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(259, 23);
            this.dtpStart.TabIndex = 19;
            // 
            // dgvBookingList
            // 
            this.dgvBookingList.AllowUserToAddRows = false;
            this.dgvBookingList.AllowUserToDeleteRows = false;
            this.dgvBookingList.AllowUserToOrderColumns = true;
            this.dgvBookingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingList.ColumnHeadersHeight = 30;
            this.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.RoomId,
            this.RoomName,
            this.ClassId,
            this.ClassName,
            this.TeacherId,
            this.Teacher,
            this.UserName,
            this.SDateTIme,
            this.EDateTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingList.EnableHeadersVisualStyles = false;
            this.dgvBookingList.GridColor = System.Drawing.Color.Black;
            this.dgvBookingList.Location = new System.Drawing.Point(12, 211);
            this.dgvBookingList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBookingList.Name = "dgvBookingList";
            this.dgvBookingList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookingList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingList.Size = new System.Drawing.Size(813, 203);
            this.dgvBookingList.TabIndex = 18;
            this.dgvBookingList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookingList_CellDoubleClick);
            // 
            // BookingId
            // 
            this.BookingId.DataPropertyName = "BookingId";
            this.BookingId.HeaderText = "BookingId";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            this.BookingId.Visible = false;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "RoomId";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            this.RoomId.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Room";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "Class Id";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            this.ClassId.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "Teacher";
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // Teacher
            // 
            this.Teacher.DataPropertyName = "TeacherName";
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Booked by";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // SDateTIme
            // 
            this.SDateTIme.DataPropertyName = "SDateTime";
            this.SDateTIme.HeaderText = "Start Date Time";
            this.SDateTIme.Name = "SDateTIme";
            this.SDateTIme.ReadOnly = true;
            // 
            // EDateTime
            // 
            this.EDateTime.DataPropertyName = "EDateTime";
            this.EDateTime.HeaderText = "End Date Time";
            this.EDateTime.Name = "EDateTime";
            this.EDateTime.ReadOnly = true;
            // 
            // rdoCUD
            // 
            this.rdoCUD.AutoSize = true;
            this.rdoCUD.Checked = true;
            this.rdoCUD.Location = new System.Drawing.Point(59, 13);
            this.rdoCUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoCUD.Name = "rdoCUD";
            this.rdoCUD.Size = new System.Drawing.Size(178, 21);
            this.rdoCUD.TabIndex = 35;
            this.rdoCUD.TabStop = true;
            this.rdoCUD.Text = "Create/Update/Cancel";
            this.rdoCUD.UseVisualStyleBackColor = true;
            this.rdoCUD.CheckedChanged += new System.EventHandler(this.RdoCUD_CheckedChanged);
            // 
            // rdoFilter
            // 
            this.rdoFilter.AutoSize = true;
            this.rdoFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdoFilter.Location = new System.Drawing.Point(245, 13);
            this.rdoFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFilter.Name = "rdoFilter";
            this.rdoFilter.Size = new System.Drawing.Size(55, 21);
            this.rdoFilter.TabIndex = 36;
            this.rdoFilter.Text = "Filter";
            this.rdoFilter.UseVisualStyleBackColor = true;
            this.rdoFilter.CheckedChanged += new System.EventHandler(this.rdoFilter_CheckedChanged);
            // 
            // cballdates
            // 
            this.cballdates.AutoSize = true;
            this.cballdates.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cballdates.Location = new System.Drawing.Point(318, 13);
            this.cballdates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cballdates.Name = "cballdates";
            this.cballdates.Size = new System.Drawing.Size(83, 21);
            this.cballdates.TabIndex = 37;
            this.cballdates.Text = "All Dates";
            this.cballdates.UseVisualStyleBackColor = true;
            this.cballdates.Visible = false;
            this.cballdates.CheckedChanged += new System.EventHandler(this.Cballdates_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.cballdates);
            this.Controls.Add(this.rdoFilter);
            this.Controls.Add(this.rdoCUD);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboxClass);
            this.Controls.Add(this.cboxStaff);
            this.Controls.Add(this.cboxRoom);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dgvBookingList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingManager";
            this.Load += new System.EventHandler(this.BookingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dgvBookingList;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboxRoom;
        private System.Windows.Forms.ComboBox cboxStaff;
        private System.Windows.Forms.ComboBox cboxClass;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rdoCUD;
        private System.Windows.Forms.RadioButton rdoFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDateTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDateTime;
        private System.Windows.Forms.CheckBox cballdates;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}