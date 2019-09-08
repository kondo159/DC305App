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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.EquipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.Equipments = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
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
            this.lblRoomName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(12, 9);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(91, 17);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "Room Name";
            // 
            // txtRoomNameValue
            // 
            this.txtRoomNameValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNameValue.Location = new System.Drawing.Point(15, 28);
            this.txtRoomNameValue.Name = "txtRoomNameValue";
            this.txtRoomNameValue.Size = new System.Drawing.Size(259, 23);
            this.txtRoomNameValue.TabIndex = 1;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(12, 63);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(68, 17);
            this.lblCapacity.TabIndex = 0;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 139);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 153);
            this.txtDescriptionValue.TabIndex = 1;
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomList.Location = new System.Drawing.Point(296, 16);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(70, 17);
            this.lblRoomList.TabIndex = 0;
            this.lblRoomList.Text = "Room List";
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            this.dgvRoomList.AllowUserToOrderColumns = true;
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomList.ColumnHeadersHeight = 30;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomName,
            this.RoomCapacity,
            this.RoomId,
            this.RoomDescription,
            this.RoomEnable});
            this.dgvRoomList.EnableHeadersVisualStyles = false;
            this.dgvRoomList.GridColor = System.Drawing.Color.Black;
            this.dgvRoomList.Location = new System.Drawing.Point(299, 41);
            this.dgvRoomList.MultiSelect = false;
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoomList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoomList.Size = new System.Drawing.Size(527, 155);
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
            this.btnDisableRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDisableRoom.Enabled = false;
            this.btnDisableRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnDisableRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableRoom.Location = new System.Drawing.Point(157, 315);
            this.btnDisableRoom.Name = "btnDisableRoom";
            this.btnDisableRoom.Size = new System.Drawing.Size(117, 28);
            this.btnDisableRoom.TabIndex = 3;
            this.btnDisableRoom.Text = "Disable";
            this.btnDisableRoom.UseVisualStyleBackColor = false;
            this.btnDisableRoom.Click += new System.EventHandler(this.BtnDisableRoom_Click);
            this.btnDisableRoom.MouseEnter += new System.EventHandler(this.BtnDisableRoom_MouseEnter);
            this.btnDisableRoom.MouseLeave += new System.EventHandler(this.BtnDisableRoom_MouseLeave);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.Location = new System.Drawing.Point(730, 16);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(96, 23);
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Click += new System.EventHandler(this.BtnEditRoom_Click);
            this.btnEditRoom.MouseEnter += new System.EventHandler(this.BtnEditRoom_MouseEnter);
            this.btnEditRoom.MouseLeave += new System.EventHandler(this.BtnEditRoom_MouseLeave);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
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
            this.pnlMainContent.Size = new System.Drawing.Size(838, 465);
            this.pnlMainContent.TabIndex = 4;
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacity.Location = new System.Drawing.Point(15, 82);
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
            this.numCapacity.Size = new System.Drawing.Size(58, 23);
            this.numCapacity.TabIndex = 4;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResetData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnResetData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(157, 354);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(117, 28);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            this.btnResetData.MouseEnter += new System.EventHandler(this.BtnResetData_MouseEnter);
            this.btnResetData.MouseLeave += new System.EventHandler(this.BtnResetData_MouseLeave);
            // 
            // dgvEquipments
            // 
            this.dgvEquipments.AllowUserToAddRows = false;
            this.dgvEquipments.AllowUserToDeleteRows = false;
            this.dgvEquipments.AllowUserToOrderColumns = true;
            this.dgvEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquipments.ColumnHeadersHeight = 30;
            this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipId,
            this.EquipName,
            this.EquipQuantity,
            this.EquipDescription});
            this.dgvEquipments.EnableHeadersVisualStyles = false;
            this.dgvEquipments.GridColor = System.Drawing.Color.Black;
            this.dgvEquipments.Location = new System.Drawing.Point(299, 245);
            this.dgvEquipments.MultiSelect = false;
            this.dgvEquipments.Name = "dgvEquipments";
            this.dgvEquipments.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipments.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEquipments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquipments.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEquipments.Size = new System.Drawing.Size(527, 137);
            this.dgvEquipments.TabIndex = 2;
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
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateRoom.Enabled = false;
            this.btnUpdateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(15, 354);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(120, 28);
            this.btnUpdateRoom.TabIndex = 0;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.BtnUpdateRoom_Click);
            this.btnUpdateRoom.MouseEnter += new System.EventHandler(this.BtnUpdateRoom_MouseEnter);
            this.btnUpdateRoom.MouseLeave += new System.EventHandler(this.BtnUpdateRoom_MouseLeave);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(15, 315);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(117, 28);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.BtnCreateRoom_Click);
            this.btnCreateRoom.MouseEnter += new System.EventHandler(this.BtnCreateRoom_MouseEnter);
            this.btnCreateRoom.MouseLeave += new System.EventHandler(this.BtnCreateRoom_MouseLeave);
            // 
            // Equipments
            // 
            this.Equipments.AutoSize = true;
            this.Equipments.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipments.Location = new System.Drawing.Point(296, 219);
            this.Equipments.Name = "Equipments";
            this.Equipments.Size = new System.Drawing.Size(83, 17);
            this.Equipments.TabIndex = 0;
            this.Equipments.Text = "Equipments";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddEquipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(628, 219);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(96, 23);
            this.btnAddEquipment.TabIndex = 3;
            this.btnAddEquipment.Text = "Add";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.BtnAddEquipment_Click);
            this.btnAddEquipment.MouseEnter += new System.EventHandler(this.BtnAddEquipment_MouseEnter);
            this.btnAddEquipment.MouseLeave += new System.EventHandler(this.BtnAddEquipment_MouseLeave);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveEquipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEquipment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEquipment.Location = new System.Drawing.Point(730, 219);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveEquipment.TabIndex = 3;
            this.btnRemoveEquipment.Text = "Remove";
            this.btnRemoveEquipment.UseVisualStyleBackColor = false;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.BtnRemoveEquipment_Click);
            this.btnRemoveEquipment.MouseEnter += new System.EventHandler(this.BtnRemoveEquipment_MouseEnter);
            this.btnRemoveEquipment.MouseLeave += new System.EventHandler(this.BtnRemoveEquipment_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.pnlMainContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManager";
            this.Text = "Room Manager";
            this.Load += new System.EventHandler(this.RoomManager_Load);
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