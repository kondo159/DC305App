using DC305RoomManagementClassLibrary.Models;
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
        Equipment Equipment { get; set; } = new Equipment();
        //EquipmentType EType { get; set; } = new EquipmentType();
        List<EquipmentType> ETypeList { get; set; } = new List<EquipmentType>();

        Repository repository = new Repository();
        public InventoryManager()
        {
            InitializeComponent();
            LoadETypeNames();
            LoadEquipmentList();
        }

        /// <summary>
        /// Fills the list of Equipment Type Name (ComboBox - Type)
        /// </summary>
        private void LoadETypeNames()
        {
            List<string> ETypeNameList = new List<string>();
            ETypeList = repository.GetETypes();

            foreach(EquipmentType EType in ETypeList)
            {
                ETypeNameList.Add(EType.ETypeName);
            }

            cbItemTypeValue.DataSource = ETypeNameList;
            cbItemTypeValue.SelectedIndex = -1;
        }
        /// <summary>
        /// Loads the Inventory list into the GridView and setting the order of the collumns.
        /// </summary>
        private void LoadEquipmentList()
        {
            // Bind the List with DataGridView
            List<Inventory> list = repository.GetEquipment();
            BindingList<Inventory> bindingList = new BindingList<Inventory>(list);
            BindingSource source = new BindingSource(bindingList, null);
            dgvInventory.DataSource = source;
            
            // Hides, reorders and renames some columns
            for(int i = 0; i < dgvInventory.Columns.Count; i++)
            {
                string columnName = dgvInventory.Columns[i].Name;
                switch (columnName)
                {
                    case "EquipmentID":
                        dgvInventory.Columns[columnName].Visible = false;
                        dgvInventory.Columns[columnName].DisplayIndex = 0;
                        break;
                    case "ETypeID":
                        dgvInventory.Columns[columnName].Visible = false;
                        dgvInventory.Columns[columnName].DisplayIndex = 1;
                        break;
                    case "EquipmentName":
                        dgvInventory.Columns[columnName].DisplayIndex = 2;
                        dgvInventory.Columns[columnName].HeaderText = "Name";
                        break;
                    case "ETypeName":
                        dgvInventory.Columns[columnName].DisplayIndex = 3;
                        dgvInventory.Columns[columnName].HeaderText = "Type";
                        break;
                    case "Quantity":
                        dgvInventory.Columns[columnName].DisplayIndex = 4;
                        break;
                    case "Description":
                        dgvInventory.Columns[columnName].DisplayIndex = 5;
                        break;
                    case "Active":
                        dgvInventory.Columns[columnName].DisplayIndex = 6;
                        break;
                    default:
                        MessageBox.Show(dgvInventory.Columns[columnName].Name);
                        break;
                }
            }
            
        }

        /// <summary>
        /// Adds a new Equipment to the database
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EquipmentType EType = new EquipmentType(getETypeID(cbItemTypeValue.Text), cbItemTypeValue.Text);
            
            // If it is a new Equipment
            if(IsValid() && Equipment.EquipmentID == 0)
            {
                Equipment = new Equipment(
                    txtItemNameValue.Text, 
                    decimal.ToInt32(nudQtyValue.Value), 
                    txtDescriptionValue.Text, false
                );
                Equipment.EType = EType;

                // If there is a new EquipmentType it will be added to the database
                if (EType.ETypeID == 0)
                {
                    Equipment.EType.ETypeID = repository.SaveEType(EType);
                    LoadETypeNames();
                }

                // Reloads the List of Inventory
                if (repository.SaveEquipment(Equipment) > 0)
                {
                    LoadEquipmentList();
                }

                // Clear the Equipment property
                Equipment = new Equipment();
            }

            ClearFields(typeof(TextBox));
            ClearFields(typeof(ComboBox));
            ClearFields(typeof(NumericUpDown));
        }

        /// <summary>
        /// Clear Values of Fields of the particular Type (TextBox, ComboBox)
        /// </summary>
        private void ClearFields(Type type)
        {
            List<Control> items = GetControls(pnlMainContent, type).ToList();
            string test = type.Name;
            foreach (Control item in items)
            {
                switch (type.Name)
                {
                    case "TextBox":
                        (item as TextBox).Text = string.Empty;
                        break;
                    case "ComboBox":
                        (item as ComboBox).Text = string.Empty;
                        break;
                    case "NumericUpDown":
                        (item as NumericUpDown).Value = 0;
                        break;
                }

                errorProvider.Clear();
            }
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

        private int getETypeID(string TypeName)
        {
            EquipmentType EType = ETypeList.Find(t => t.ETypeName == TypeName) ?? new EquipmentType();
            return EType.ETypeID;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Equipment.EType = new EquipmentType(getETypeID(cbItemTypeValue.Text), cbItemTypeValue.Text);

            if (IsValid() && (Equipment.EquipmentID != 0))
            {
                //
                if (Equipment.EType.ETypeID == 0)
                {
                    Equipment.EType.ETypeID = repository.SaveEType(Equipment.EType);
                    LoadETypeNames();
                }

                Equipment.EquipmentName = txtItemNameValue.Text;
                Equipment.Quantity = (int)nudQtyValue.Value;
                Equipment.Description = txtDescriptionValue.Text;
                Equipment.Active = false;

                if (repository.SaveEquipment(Equipment) > 0)
                {
                    LoadEquipmentList();
                }

                // Clear the Equipment property
                Equipment = new Equipment(); ;
            }

            ClearFields(typeof(TextBox));
            ClearFields(typeof(ComboBox));
            ClearFields(typeof(NumericUpDown));
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvInventory.CurrentRow;
            fillEquipmentData(row);
            Equipment.Active = !Equipment.Active;
            
            repository.SaveEquipment(Equipment);
            LoadEquipmentList();

            // Clear the Equipment property
            Equipment = new Equipment();
        }

        private void DgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
            fillEquipmentData(row);
            fillFields();
        }

        private void fillFields()
        {
            txtItemNameValue.Text = Equipment.EquipmentName;
            nudQtyValue.Value = Equipment.Quantity;
            txtDescriptionValue.Text = Equipment.Description;
            cbItemTypeValue.SelectedIndex = cbItemTypeValue.FindStringExact(Equipment.EType.ETypeName);
        }

        private void fillEquipmentData(DataGridViewRow row)
        {
            Equipment.EquipmentID = (int)row.Cells["EquipmentID"].Value;
            Equipment.EquipmentName = row.Cells["EquipmentName"].Value.ToString();
            Equipment.Quantity = (int)row.Cells["Quantity"].Value;
            Equipment.Description = row.Cells["Description"].Value.ToString();
            Equipment.EType = new EquipmentType((int)row.Cells["ETypeID"].Value, row.Cells["ETypeName"].Value.ToString());
            Equipment.Active = (bool)row.Cells["Active"].Value;
        }

        private bool IsValid()
        {
            bool valid = true;

            // EType
            if(string.IsNullOrWhiteSpace(cbItemTypeValue.Text))
            {
                errorProvider.SetError(cbItemTypeValue, "A type must be specified!");
                valid = false;
            }
            else
            {
                errorProvider.SetError(cbItemTypeValue, string.Empty);
            }

            // Equipment Name
            if (string.IsNullOrWhiteSpace(txtItemNameValue.Text))
            {
                errorProvider.SetError(txtItemNameValue, "An equipment name must be specified!");
                valid = false;
            }
            else
            {
                errorProvider.SetError(txtItemNameValue, string.Empty);
            }

            return valid;
        }

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

        private void DgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if ((bool)row.Cells["Active"].Value)
            {
                btnDisable.Text = "Disable";
            }
            else
            {
                btnDisable.Text = "Activate";
            }
        }
    }
}
