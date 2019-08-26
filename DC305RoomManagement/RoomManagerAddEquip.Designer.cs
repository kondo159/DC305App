namespace DC305RoomManagement
{
    partial class RoomManagerAddEquip
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboxEquip = new System.Windows.Forms.ComboBox();
            this.numEquip = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cboxEquip
            // 
            this.cboxEquip.FormattingEnabled = true;
            this.cboxEquip.Location = new System.Drawing.Point(12, 12);
            this.cboxEquip.Name = "cboxEquip";
            this.cboxEquip.Size = new System.Drawing.Size(121, 21);
            this.cboxEquip.TabIndex = 2;
            this.cboxEquip.SelectedIndexChanged += new System.EventHandler(this.CboxEquip_SelectedIndexChanged);
            // 
            // numEquip
            // 
            this.numEquip.Location = new System.Drawing.Point(139, 12);
            this.numEquip.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numEquip.Name = "numEquip";
            this.numEquip.Size = new System.Drawing.Size(45, 20);
            this.numEquip.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RoomManagerAddEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numEquip);
            this.Controls.Add(this.cboxEquip);
            this.Controls.Add(this.btnAdd);
            this.Name = "RoomManagerAddEquip";
            this.Text = "RoomManagerAddEquip";
            ((System.ComponentModel.ISupportInitialize)(this.numEquip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboxEquip;
        private System.Windows.Forms.NumericUpDown numEquip;
        private System.Windows.Forms.Button btnCancel;
    }
}