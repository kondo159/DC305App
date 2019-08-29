namespace DC305RoomManagement
{
    partial class InventoryManager
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
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.cbItemTypeValue = new System.Windows.Forms.ComboBox();
            this.nudQtyValue = new System.Windows.Forms.NumericUpDown();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblItemQty = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lbIItemType = new System.Windows.Forms.Label();
            this.txtItemNameValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.cbItemTypeValue);
            this.pnlMainContent.Controls.Add(this.nudQtyValue);
            this.pnlMainContent.Controls.Add(this.btnEnableDisable);
            this.pnlMainContent.Controls.Add(this.btnSave);
            this.pnlMainContent.Controls.Add(this.dgvInventory);
            this.pnlMainContent.Controls.Add(this.lblItemQty);
            this.pnlMainContent.Controls.Add(this.lblItemName);
            this.pnlMainContent.Controls.Add(this.lbIItemType);
            this.pnlMainContent.Controls.Add(this.txtItemNameValue);
            this.pnlMainContent.Controls.Add(this.lblDescription);
            this.pnlMainContent.Controls.Add(this.txtDescriptionValue);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(837, 450);
            this.pnlMainContent.TabIndex = 1;
            // 
            // cbItemTypeValue
            // 
            this.cbItemTypeValue.FormattingEnabled = true;
            this.cbItemTypeValue.Location = new System.Drawing.Point(15, 39);
            this.cbItemTypeValue.Name = "cbItemTypeValue";
            this.cbItemTypeValue.Size = new System.Drawing.Size(259, 24);
            this.cbItemTypeValue.TabIndex = 9;
            this.cbItemTypeValue.Validating += new System.ComponentModel.CancelEventHandler(this.Value_Validating);
            // 
            // nudQtyValue
            // 
            this.nudQtyValue.Location = new System.Drawing.Point(18, 166);
            this.nudQtyValue.Name = "nudQtyValue";
            this.nudQtyValue.Size = new System.Drawing.Size(84, 22);
            this.nudQtyValue.TabIndex = 2;
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.Location = new System.Drawing.Point(737, 395);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(75, 23);
            this.btnEnableDisable.TabIndex = 6;
            this.btnEnableDisable.Text = "Disable";
            this.btnEnableDisable.UseVisualStyleBackColor = true;
            this.btnEnableDisable.Click += new System.EventHandler(this.BtnEnableDisable_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentID,
            this.EquipmentName,
            this.EType,
            this.Description,
            this.Quantity,
            this.Active});
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(324, 39);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(488, 350);
            this.dgvInventory.TabIndex = 8;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventory_CellDoubleClick);
            this.dgvInventory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvInventory_DataError);
            this.dgvInventory.SelectionChanged += new System.EventHandler(this.DgvInventory_SelectionChanged);
            // 
            // lblItemQty
            // 
            this.lblItemQty.AutoSize = true;
            this.lblItemQty.Location = new System.Drawing.Point(15, 146);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(56, 16);
            this.lblItemQty.TabIndex = 2;
            this.lblItemQty.Text = "Quantity";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 83);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 16);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // lbIItemType
            // 
            this.lbIItemType.AutoSize = true;
            this.lbIItemType.Location = new System.Drawing.Point(12, 20);
            this.lbIItemType.Name = "lbIItemType";
            this.lbIItemType.Size = new System.Drawing.Size(40, 16);
            this.lbIItemType.TabIndex = 2;
            this.lbIItemType.Text = "Type";
            // 
            // txtItemNameValue
            // 
            this.txtItemNameValue.Location = new System.Drawing.Point(15, 102);
            this.txtItemNameValue.Name = "txtItemNameValue";
            this.txtItemNameValue.Size = new System.Drawing.Size(259, 22);
            this.txtItemNameValue.TabIndex = 1;
            this.txtItemNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.Value_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 214);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Location = new System.Drawing.Point(15, 233);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(259, 123);
            this.txtDescriptionValue.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EquipmentID
            // 
            this.EquipmentID.DataPropertyName = "EquipmentID";
            this.EquipmentID.HeaderText = "EquipmentID";
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.Visible = false;
            // 
            // EquipmentName
            // 
            this.EquipmentName.DataPropertyName = "EquipmentName";
            this.EquipmentName.HeaderText = "Equipment Name";
            this.EquipmentName.MinimumWidth = 50;
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.Width = 200;
            // 
            // EType
            // 
            this.EType.DataPropertyName = "ETypeID";
            this.EType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.EType.HeaderText = "Type";
            this.EType.Name = "EType";
            this.EType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "InventoryManager";
            this.Text = "InventoryManager";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lbIItemType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemNameValue;
        private System.Windows.Forms.NumericUpDown nudQtyValue;
        private System.Windows.Forms.Label lblItemQty;
        private System.Windows.Forms.ComboBox cbItemTypeValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewComboBoxColumn EType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}