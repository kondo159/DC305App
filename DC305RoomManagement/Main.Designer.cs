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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pwd_Change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(7)))));
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Controls.Add(this.btnInventory);
            this.pnlSideMenu.Controls.Add(this.btnRoom);
            this.pnlSideMenu.Controls.Add(this.btnExit);
            this.pnlSideMenu.Controls.Add(this.btnClass);
            this.pnlSideMenu.Controls.Add(this.btnBooking);
            this.pnlSideMenu.Controls.Add(this.btnCourse);
            this.pnlSideMenu.Controls.Add(this.btnIssue);
            this.pnlSideMenu.Controls.Add(this.btnGroup);
            this.pnlSideMenu.Controls.Add(this.btnUser);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(155, 601);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DC305RoomManagement.Properties.Resources.it_edu_logo_main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 489);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(155, 50);
            this.btnInventory.TabIndex = 9;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnInventory.MouseEnter += new System.EventHandler(this.BtnInventory_MouseEnter);
            this.btnInventory.MouseLeave += new System.EventHandler(this.BtnInventory_MouseLeave);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(0, 433);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(155, 50);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Room Manager";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnRoom.MouseEnter += new System.EventHandler(this.BtnRoom_MouseEnter);
            this.btnRoom.MouseLeave += new System.EventHandler(this.BtnRoom_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 50);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // btnClass
            // 
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Location = new System.Drawing.Point(0, 377);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(155, 50);
            this.btnClass.TabIndex = 4;
            this.btnClass.Text = "Class Manager";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnClass.MouseEnter += new System.EventHandler(this.BtnClass_MouseEnter);
            this.btnClass.MouseLeave += new System.EventHandler(this.BtnClass_MouseLeave);
            // 
            // btnBooking
            // 
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(0, 97);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(155, 50);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking Manager";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnBooking.MouseEnter += new System.EventHandler(this.BtnBooking_MouseEnter);
            this.btnBooking.MouseLeave += new System.EventHandler(this.BtnBooking_MouseLeave);
            // 
            // btnCourse
            // 
            this.btnCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(0, 321);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(155, 50);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course Manager";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnCourse.MouseEnter += new System.EventHandler(this.BtnCourse_MouseEnter);
            this.btnCourse.MouseLeave += new System.EventHandler(this.BtnCourse_MouseLeave);
            // 
            // btnIssue
            // 
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(0, 153);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(155, 50);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue Manager";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnIssue.MouseEnter += new System.EventHandler(this.BtnIssue_MouseEnter);
            this.btnIssue.MouseLeave += new System.EventHandler(this.BtnIssue_MouseLeave);
            // 
            // btnGroup
            // 
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.Location = new System.Drawing.Point(0, 265);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(155, 50);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Group Manager";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnGroup.MouseEnter += new System.EventHandler(this.BtnGroup_MouseEnter);
            this.btnGroup.MouseLeave += new System.EventHandler(this.BtnGroup_MouseLeave);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 209);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(155, 50);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "User Manager";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnUser.MouseEnter += new System.EventHandler(this.BtnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.BtnUser_MouseLeave);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.pwd_Change);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(155, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(853, 97);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            // 
            // pwd_Change
            // 
            this.pwd_Change.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_Change.Location = new System.Drawing.Point(710, 64);
            this.pwd_Change.Name = "pwd_Change";
            this.pwd_Change.Size = new System.Drawing.Size(140, 27);
            this.pwd_Change.TabIndex = 16;
            this.pwd_Change.Text = "Change Password";
            this.pwd_Change.UseVisualStyleBackColor = true;
            this.pwd_Change.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.Location = new System.Drawing.Point(25, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(181, 36);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "Main Menu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(760, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current User";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEdu Systems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnIssue;
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
        private System.Windows.Forms.Button pwd_Change;
    }
}
