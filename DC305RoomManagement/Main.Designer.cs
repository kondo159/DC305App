namespace DC305RoomManagement
{
    partial class Main
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSideMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Controls.Add(this.btnInventory);
            this.pnlSideMenu.Controls.Add(this.btnIssue);
            this.pnlSideMenu.Controls.Add(this.btnCalendar);
            this.pnlSideMenu.Controls.Add(this.btnUser);
            this.pnlSideMenu.Controls.Add(this.btnExit);
            this.pnlSideMenu.Controls.Add(this.btnClass);
            this.pnlSideMenu.Controls.Add(this.btnGroup);
            this.pnlSideMenu.Controls.Add(this.btnCourse);
            this.pnlSideMenu.Controls.Add(this.btnRoom);
            this.pnlSideMenu.Controls.Add(this.btnBooking);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(155, 601);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(0, 454);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(155, 45);
            this.btnInventory.TabIndex = 9;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(0, 403);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(155, 45);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue Manager";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(0, 505);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(155, 45);
            this.btnCalendar.TabIndex = 10;
            this.btnCalendar.Text = "View Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(0, 352);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(155, 45);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "User Manager";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnClass
            // 
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(0, 199);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(155, 45);
            this.btnClass.TabIndex = 4;
            this.btnClass.Text = "Class Manager";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(0, 301);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(155, 45);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Group Manager";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(0, 250);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(155, 45);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course Manager";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(0, 148);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(155, 45);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Room Manager";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(0, 97);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(155, 45);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking Manager";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(155, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(853, 97);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.Location = new System.Drawing.Point(25, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(162, 40);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "Main Menu";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(155, 97);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(853, 504);
            this.pnlMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DC305RoomManagement.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
