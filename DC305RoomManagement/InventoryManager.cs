﻿using DC305RoomManagementClassLibrary.Models;
using DC305RoomManagementClassLibrary.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC305RoomManagement
{
    public partial class InventoryManager : Form
    {
        private Equipment Equipment { get; set; } = new Equipment();

        private static Repository repository = new Repository();

        public InventoryManager()
        {
            InitializeComponent();
            LoadETypeNames();
            LoadEquipmentList();
        }

        /// <summary>
        /// Fills the list of Equipment Type Name (ComboBox - Type)
        /// </summary>
        private void LoadETypeNames(int selectedID = 0)
        {
            cbItemTypeValue.ValueMember = "ETypeID";
            cbItemTypeValue.DisplayMember = "ETypeName";
            cbItemTypeValue.DataSource = repository.GetETypes();
            //cbItemTypeValue.SelectedIndex = selectedIndex;
            cbItemTypeValue.SelectedValue = selectedID;
        }

        /// <summary>
        /// Loads the Inventory list into the GridView and setting the order of the collumns.
        /// </summary>
        private void LoadEquipmentList()
        {
            EType.ValueMember = "ETypeID";
            EType.DisplayMember = "ETypeName";
            EType.DataSource = repository.GetETypes();
            dgvInventory.DataSource = repository.GetEquipment();
        }

        /// <summary>
        /// Get All Controls by the Type in the Control
        /// </summary>
        /// <param name="control">The main control containing necessary controls</param>
        /// <param name="type">The Type of necessary controls</param>
        /// <returns>Collection of Controls</returns>
        public IEnumerable<Control> GetControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Disables the Equipment selected in DataGridView
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Arguments</param>
        private void BtnEnableDisable_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvInventory.CurrentRow;
            fillEquipmentData(row);
            Equipment.Active = !Equipment.Active;
            
            repository.SaveEquipment(Equipment);
            LoadEquipmentList();

            // Clear the Equipment property
            Equipment = new Equipment();
        }


        /// <summary>
        /// Selects the Equipment for updating and fills fields its data
        /// </summary>
        /// <param name="sender">Cell of DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
            fillEquipmentData(row);
            fillFields();
        }

        /// <summary>
        /// Fills the fields the Equipment data
        /// </summary>
        private void fillFields()
        {
            txtItemNameValue.Text = Equipment.EquipmentName;
            nudQtyValue.Value = Equipment.Quantity;
            txtDescriptionValue.Text = Equipment.Description;
            cbItemTypeValue.SelectedValue = Equipment.ETypeID;
        }

        /// <summary>
        /// Fills the Equipment data using fields data
        /// </summary>
        public void fillEquipment()
        {
            Equipment.EquipmentName = txtItemNameValue.Text;
            Equipment.Quantity = (int)nudQtyValue.Value;
            Equipment.Description = txtDescriptionValue.Text;
            if(Equipment.EquipmentID == 0)
            {
                Equipment.Active = false;
            } 
        }

        /// <summary>
        /// Fills the Equipment data using data from DataGridView Row
        /// </summary>
        /// <param name="row">Row of DataGridView</param>
        private void fillEquipmentData(DataGridViewRow row)
        {
            Equipment.EquipmentID = (int)row.Cells["EquipmentID"].Value;
            Equipment.EquipmentName = row.Cells["EquipmentName"].Value.ToString();
            Equipment.Quantity = (int)row.Cells["Quantity"].Value;
            Equipment.Description = row.Cells["Description"].Value.ToString();
            Equipment.ETypeID = (int)row.Cells["EType"].Value;
            Equipment.Active = (bool)row.Cells["Active"].Value;
        }

        /// <summary>
        /// Checks if the fields were filled
        /// </summary>
        /// <returns>True or False</returns>
        private bool IsValid()
        {
            bool valid = true;

            // EType
            if(string.IsNullOrWhiteSpace(cbItemTypeValue.Text))
            {
                valid = false;
            }

            // Equipment Name
            if (string.IsNullOrWhiteSpace(txtItemNameValue.Text))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// Checks if the field was filled
        /// </summary>
        /// <param name="sender">Field</param>
        /// <param name="e">Event Arguments</param>
        private void Value_Validating(object sender, CancelEventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "ComboBox":
                    if (string.IsNullOrWhiteSpace((sender as ComboBox).Text))
                    {
                        errorProvider.SetError((sender as ComboBox), "A type must be specified!");
                    }
                    else
                    {
                        errorProvider.SetError((sender as ComboBox), string.Empty);
                    }
                    break;
                case "TextBox":
                    if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
                    {
                        errorProvider.SetError((sender as TextBox), "An equipment name must be specified!");
                    }
                    else
                    {
                        errorProvider.SetError((sender as TextBox), string.Empty);
                    }
                    break;
            }
        }

        /// <summary>
        /// Changes the text of Button (btnEnableDisable) depends on the selected equipment is active or not
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if ((bool)row.Cells["Active"].Value)
            {
                btnEnableDisable.Text = "Disable";
            }
            else
            {
                btnEnableDisable.Text = "Activate";
            }
        }

        /// <summary>
        /// Saves the Equipment data to the database
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Arguments</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                int ETypeID = (cbItemTypeValue.FindStringExact(cbItemTypeValue.Text)) == -1 ? 0
                    : (int)(cbItemTypeValue.SelectedValue ?? 0);

                if(ETypeID == 0)
                {
                    ETypeID = repository.SaveEType(new EquipmentType(ETypeID, cbItemTypeValue.Text));
                    LoadETypeNames(ETypeID);
                }

                Equipment.ETypeID = ETypeID;

                fillEquipment();

                int id = repository.SaveEquipment(Equipment);
                if (id != 0)
                {
                    FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
                    FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
                    
                    LoadEquipmentList();

                    MessageBox.Show("Data was saved successfully!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occured.\nData was not saved!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All required field must be specified!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles errors iserting Equipment Type into DataGridView
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvInventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgvInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgvInventory.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvInventory.Columns[e.ColumnIndex]).DataSource = repository.GetETypes();
                    e.ThrowException = false;
                }
            }
        }

        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.White;
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.Black;
        }

        private void BtnEnableDisable_MouseEnter(object sender, EventArgs e)
        {
            btnEnableDisable.ForeColor = Color.White;
        }

        private void BtnEnableDisable_MouseLeave(object sender, EventArgs e)
        {
            btnEnableDisable.ForeColor = Color.Black;
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
        }
    }
}
