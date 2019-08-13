﻿namespace DC305RoomManagement
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
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomNameValue = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacityValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.btnDisableRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.dgvEquipments = new System.Windows.Forms.DataGridView();
            this.Equipments = new System.Windows.Forms.Label();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnDisableEquipment = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).BeginInit();
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
            // txtCapacityValue
            // 
            this.txtCapacityValue.Location = new System.Drawing.Point(15, 103);
            this.txtCapacityValue.Name = "txtCapacityValue";
            this.txtCapacityValue.Size = new System.Drawing.Size(209, 22);
            this.txtCapacityValue.TabIndex = 1;
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
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(299, 41);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.Size = new System.Drawing.Size(319, 155);
            this.dgvRoomList.TabIndex = 2;
            // 
            // btnDisableRoom
            // 
            this.btnDisableRoom.Location = new System.Drawing.Point(543, 15);
            this.btnDisableRoom.Name = "btnDisableRoom";
            this.btnDisableRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDisableRoom.TabIndex = 3;
            this.btnDisableRoom.Text = "Disable";
            this.btnDisableRoom.UseVisualStyleBackColor = true;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(462, 15);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnResetData);
            this.pnlMainContent.Controls.Add(this.dgvEquipments);
            this.pnlMainContent.Controls.Add(this.btnUpdateRoom);
            this.pnlMainContent.Controls.Add(this.lblRoomName);
            this.pnlMainContent.Controls.Add(this.btnCreateRoom);
            this.pnlMainContent.Controls.Add(this.Equipments);
            this.pnlMainContent.Controls.Add(this.txtRoomNameValue);
            this.pnlMainContent.Controls.Add(this.dgvRoomList);
            this.pnlMainContent.Controls.Add(this.lblDescription);
            this.pnlMainContent.Controls.Add(this.btnEditEquipment);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Controls.Add(this.lblRoomList);
            this.pnlMainContent.Controls.Add(this.btnDisableEquipment);
            this.pnlMainContent.Controls.Add(this.txtCapacityValue);
            this.pnlMainContent.Controls.Add(this.btnEditRoom);
            this.pnlMainContent.Controls.Add(this.lblCapacity);
            this.pnlMainContent.Controls.Add(this.btnDisableRoom);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(638, 461);
            this.pnlMainContent.TabIndex = 4;
            // 
            // dgvEquipments
            // 
            this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipments.Location = new System.Drawing.Point(299, 245);
            this.dgvEquipments.Name = "dgvEquipments";
            this.dgvEquipments.Size = new System.Drawing.Size(319, 155);
            this.dgvEquipments.TabIndex = 2;
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
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(462, 219);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnEditEquipment.TabIndex = 3;
            this.btnEditEquipment.Text = "Edit";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            // 
            // btnDisableEquipment
            // 
            this.btnDisableEquipment.Location = new System.Drawing.Point(543, 219);
            this.btnDisableEquipment.Name = "btnDisableEquipment";
            this.btnDisableEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnDisableEquipment.TabIndex = 3;
            this.btnDisableEquipment.Text = "Disable";
            this.btnDisableEquipment.UseVisualStyleBackColor = true;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(184, 414);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(265, 414);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRoom.TabIndex = 0;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(346, 414);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(75, 23);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            // 
            // RoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 461);
            this.Controls.Add(this.pnlMainContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManager";
            this.Text = "Room Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomNameValue;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacityValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Button btnDisableRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.DataGridView dgvEquipments;
        private System.Windows.Forms.Label Equipments;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnDisableEquipment;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnUpdateRoom;
    }
}