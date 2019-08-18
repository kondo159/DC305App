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
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblItemQty = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lbIItemType = new System.Windows.Forms.Label();
            this.txtItemNameValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.pnlMainContent.Controls.Add(this.btnDisable);
            this.pnlMainContent.Controls.Add(this.btnAdd);
            this.pnlMainContent.Controls.Add(this.btnUpdate);
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
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(455, 395);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 6;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(374, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(324, 39);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(488, 317);
            this.dgvInventory.TabIndex = 8;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventory_CellDoubleClick);
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
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lbIItemType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemNameValue;
        private System.Windows.Forms.NumericUpDown nudQtyValue;
        private System.Windows.Forms.Label lblItemQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbItemTypeValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}