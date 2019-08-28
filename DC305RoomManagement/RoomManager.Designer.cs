namespace DC305RoomManagement
{
    partial class RoomManager
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
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomNameValue = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDisableRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvEquipments = new System.Windows.Forms.DataGridView();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.Equipments = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.EquipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(12, 22);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(85, 16);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "Room Name";
            // 
            // txtRoomNameValue
            // 
            this.txtRoomNameValue.Location = new System.Drawing.Point(15, 41);
            this.txtRoomNameValue.Name = "txtRoomNameValue";
            this.txtRoomNameValue.Size = new System.Drawing.Size(209, 22);
            this.txtRoomNameValue.TabIndex = 1;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 84);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(61, 16);
            this.lblCapacity.TabIndex = 0;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 149);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 168);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 232);
            this.txtDescriptionValue.TabIndex = 1;
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Location = new System.Drawing.Point(296, 22);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(68, 16);
            this.lblRoomList.TabIndex = 0;
            this.lblRoomList.Text = "Room List";
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            this.dgvRoomList.AllowUserToOrderColumns = true;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomName,
            this.RoomCapacity,
            this.RoomId,
            this.RoomDescription,
            this.RoomEnable});
            this.dgvRoomList.Location = new System.Drawing.Point(299, 41);
            this.dgvRoomList.MultiSelect = false;
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.Size = new System.Drawing.Size(446, 172);
            this.dgvRoomList.TabIndex = 2;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "Name";
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // RoomCapacity
            // 
            this.RoomCapacity.DataPropertyName = "Capacity";
            this.RoomCapacity.HeaderText = "Capacity";
            this.RoomCapacity.Name = "RoomCapacity";
            this.RoomCapacity.ReadOnly = true;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "Id";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            this.RoomId.Visible = false;
            // 
            // RoomDescription
            // 
            this.RoomDescription.DataPropertyName = "Description";
            this.RoomDescription.HeaderText = "Description";
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.ReadOnly = true;
            // 
            // RoomEnable
            // 
            this.RoomEnable.DataPropertyName = "Enable";
            this.RoomEnable.HeaderText = "Enable";
            this.RoomEnable.Name = "RoomEnable";
            this.RoomEnable.ReadOnly = true;
            // 
            // btnDisableRoom
            // 
            this.btnDisableRoom.Enabled = false;
            this.btnDisableRoom.Location = new System.Drawing.Point(184, 414);
            this.btnDisableRoom.Name = "btnDisableRoom";
            this.btnDisableRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDisableRoom.TabIndex = 3;
            this.btnDisableRoom.Text = "Disable";
            this.btnDisableRoom.UseVisualStyleBackColor = true;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(670, 12);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.BtnEditRoom_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMainContent.Controls.Add(this.numCapacity);
            this.pnlMainContent.Controls.Add(this.btnResetData);
            this.pnlMainContent.Controls.Add(this.dgvEquipments);
            this.pnlMainContent.Controls.Add(this.btnUpdateRoom);
            this.pnlMainContent.Controls.Add(this.lblRoomName);
            this.pnlMainContent.Controls.Add(this.btnCreateRoom);
            this.pnlMainContent.Controls.Add(this.Equipments);
            this.pnlMainContent.Controls.Add(this.txtRoomNameValue);
            this.pnlMainContent.Controls.Add(this.dgvRoomList);
            this.pnlMainContent.Controls.Add(this.lblDescription);
            this.pnlMainContent.Controls.Add(this.btnAddEquipment);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Controls.Add(this.lblRoomList);
            this.pnlMainContent.Controls.Add(this.btnRemoveEquipment);
            this.pnlMainContent.Controls.Add(this.btnEditRoom);
            this.pnlMainContent.Controls.Add(this.lblCapacity);
            this.pnlMainContent.Controls.Add(this.btnDisableRoom);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(757, 461);
            this.pnlMainContent.TabIndex = 4;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(15, 103);
            this.numCapacity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(58, 22);
            this.numCapacity.TabIndex = 4;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(265, 414);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(75, 23);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // dgvEquipments
            // 
            this.dgvEquipments.AllowUserToAddRows = false;
            this.dgvEquipments.AllowUserToDeleteRows = false;
            this.dgvEquipments.AllowUserToOrderColumns = true;
            this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipId,
            this.EquipName,
            this.EquipQuantity,
            this.EquipDescription});
            this.dgvEquipments.Location = new System.Drawing.Point(299, 245);
            this.dgvEquipments.MultiSelect = false;
            this.dgvEquipments.Name = "dgvEquipments";
            this.dgvEquipments.ReadOnly = true;
            this.dgvEquipments.Size = new System.Drawing.Size(446, 155);
            this.dgvEquipments.TabIndex = 2;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Enabled = false;
            this.btnUpdateRoom.Location = new System.Drawing.Point(103, 414);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRoom.TabIndex = 0;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.BtnUpdateRoom_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(22, 414);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.BtnCreateRoom_Click);
            // 
            // Equipments
            // 
            this.Equipments.AutoSize = true;
            this.Equipments.Location = new System.Drawing.Point(296, 226);
            this.Equipments.Name = "Equipments";
            this.Equipments.Size = new System.Drawing.Size(79, 16);
            this.Equipments.TabIndex = 0;
            this.Equipments.Text = "Equipments";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(500, 219);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnAddEquipment.TabIndex = 3;
            this.btnAddEquipment.Text = "Add";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.BtnAddEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(581, 219);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEquipment.TabIndex = 3;
            this.btnRemoveEquipment.Text = "Remove";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.BtnRemoveEquipment_Click);
            // 
            // EquipId
            // 
            this.EquipId.DataPropertyName = "EquipId";
            this.EquipId.HeaderText = "ID";
            this.EquipId.Name = "EquipId";
            this.EquipId.ReadOnly = true;
            this.EquipId.Visible = false;
            // 
            // EquipName
            // 
            this.EquipName.DataPropertyName = "name";
            this.EquipName.HeaderText = "Name";
            this.EquipName.Name = "EquipName";
            this.EquipName.ReadOnly = true;
            // 
            // EquipQuantity
            // 
            this.EquipQuantity.DataPropertyName = "Quantity";
            this.EquipQuantity.HeaderText = "Quantity";
            this.EquipQuantity.Name = "EquipQuantity";
            this.EquipQuantity.ReadOnly = true;
            // 
            // EquipDescription
            // 
            this.EquipDescription.DataPropertyName = "Description";
            this.EquipDescription.HeaderText = "Description";
            this.EquipDescription.Name = "EquipDescription";
            this.EquipDescription.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 461);
            this.Controls.Add(this.pnlMainContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManager";
            this.Text = "Room Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomNameValue;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Button btnDisableRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.DataGridView dgvEquipments;
        private System.Windows.Forms.Label Equipments;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RoomEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}