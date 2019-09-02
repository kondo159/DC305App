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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(202, 280);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(40, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(202, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(40, 251);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(121, 280);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 29;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cboxClass
            // 
            this.cboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Location = new System.Drawing.Point(72, 224);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(195, 21);
            this.cboxClass.TabIndex = 28;
            // 
            // cboxStaff
            // 
            this.cboxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStaff.FormattingEnabled = true;
            this.cboxStaff.Location = new System.Drawing.Point(72, 197);
            this.cboxStaff.Name = "cboxStaff";
            this.cboxStaff.Size = new System.Drawing.Size(195, 21);
            this.cboxStaff.TabIndex = 27;
            // 
            // cboxRoom
            // 
            this.cboxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRoom.FormattingEnabled = true;
            this.cboxRoom.Location = new System.Drawing.Point(72, 170);
            this.cboxRoom.Name = "cboxRoom";
            this.cboxRoom.Size = new System.Drawing.Size(195, 21);
            this.cboxRoom.TabIndex = 26;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(31, 232);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 25;
            this.lblClass.Text = "Class:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(16, 205);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(50, 13);
            this.lblTeacher.TabIndex = 24;
            this.lblTeacher.Text = "Teacher:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(28, 178);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 23;
            this.lblRoom.Text = "Room:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(17, 150);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 13);
            this.lblToDate.TabIndex = 22;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(7, 125);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 21;
            this.lblFromDate.Text = "From Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd MMMM yyyy hh:mm tt";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(72, 144);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(195, 20);
            this.dtpEnd.TabIndex = 20;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd MMMM yyyy hh:mm tt";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(72, 118);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(195, 20);
            this.dtpStart.TabIndex = 19;
            // 
            // dgvBookingList
            // 
            this.dgvBookingList.AllowUserToAddRows = false;
            this.dgvBookingList.AllowUserToDeleteRows = false;
            this.dgvBookingList.AllowUserToOrderColumns = true;
            this.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvBookingList.Location = new System.Drawing.Point(291, 12);
            this.dgvBookingList.Name = "dgvBookingList";
            this.dgvBookingList.ReadOnly = true;
            this.dgvBookingList.Size = new System.Drawing.Size(534, 441);
            this.dgvBookingList.TabIndex = 18;
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
            this.rdoCUD.Location = new System.Drawing.Point(37, 26);
            this.rdoCUD.Name = "rdoCUD";
            this.rdoCUD.Size = new System.Drawing.Size(134, 17);
            this.rdoCUD.TabIndex = 35;
            this.rdoCUD.TabStop = true;
            this.rdoCUD.Text = "Create/Update/Cancel";
            this.rdoCUD.UseVisualStyleBackColor = true;
            this.rdoCUD.CheckedChanged += new System.EventHandler(this.RdoCUD_CheckedChanged);
            // 
            // rdoFilter
            // 
            this.rdoFilter.AutoSize = true;
            this.rdoFilter.Location = new System.Drawing.Point(177, 26);
            this.rdoFilter.Name = "rdoFilter";
            this.rdoFilter.Size = new System.Drawing.Size(47, 17);
            this.rdoFilter.TabIndex = 36;
            this.rdoFilter.Text = "Filter";
            this.rdoFilter.UseVisualStyleBackColor = true;
            this.rdoFilter.CheckedChanged += new System.EventHandler(this.rdoFilter_CheckedChanged);
            // 
            // cballdates
            // 
            this.cballdates.AutoSize = true;
            this.cballdates.Location = new System.Drawing.Point(72, 95);
            this.cballdates.Name = "cballdates";
            this.cballdates.Size = new System.Drawing.Size(68, 17);
            this.cballdates.TabIndex = 37;
            this.cballdates.Text = "All Dates";
            this.cballdates.UseVisualStyleBackColor = true;
            this.cballdates.Visible = false;
            this.cballdates.CheckedChanged += new System.EventHandler(this.Cballdates_CheckedChanged);
            // 
            // BookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.Name = "BookingManager";
            this.Text = "BookingManager";
            this.Load += new System.EventHandler(this.BookingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).EndInit();
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
    }
}