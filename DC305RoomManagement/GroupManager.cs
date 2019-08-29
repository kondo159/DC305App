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
    public partial class GroupManager : Form
    {
        private Group Group { get; set; } = new Group();
        private static Repository repository = new Repository();

        public GroupManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills form fields with data from the Group object
        /// </summary>
        /// <param name="group">Group object</param>
        private void fillFields(Group group)
        {
            txtGroupNameValue.Text = group.GroupName;
            txtNotesValue.Text = group.Description;
        }

        /// <summary>
        /// Creates Group with data from form fields
        /// </summary>
        /// <returns>Group</returns>
        private void fillGroup()
        {
            Group.GroupName = txtGroupNameValue.Text;
            Group.Description = txtNotesValue.Text;
        }

        /// <summary>
        /// Fills Group property by data from the row of the DataGridView
        /// </summary>
        /// <param name="row">DataGridView Row of data</param>
        private void fillGroupData(DataGridViewRow row)
        {
            Group.GroupID = (int)row.Cells["GroupID"].Value;
            Group.GroupName = row.Cells["GroupName"].Value.ToString();
            Group.Description = row.Cells["Description"].Value.ToString();
            Group.Active = (bool)row.Cells["Active"].Value;
        }

        /// <summary>
        /// Loads the Groups into DataGridView
        /// </summary>
        private void LoadGroups()
        {
            dgvGroups.DataSource = repository.GetGroups();
        }

        /// <summary>
        /// Loads the Members into DataGridView
        /// </summary>
        private void LoadMembers()
        {
            int GroupID = (int)(dgvGroups.CurrentRow?.Cells["GroupID"].Value ?? 0);

            dgvMembers.DataSource = repository.GetGroupMembers(GroupID);
        }

        /// <summary>
        /// Validation of the form fields
        /// </summary>
        /// <returns>Returns true if form filds are filled</returns>
        private bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtGroupNameValue.Text))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// A handler for loading the Groups and Members data into DataGridViews when the form load
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Event Arguments</param>
        private void GroupManager_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadMembers();
        }

        /// <summary>
        /// A handler for saving the Group data into the database
        /// </summary>
        /// <param name="sender">Button "Save"</param>
        /// <param name="e">Event Arguments</param>
        private void BtnSaveGroup_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                fillGroup(); // Fills the Group property by data from the form fields

                int id = repository.SaveGroup(Group);

                // If data was saved successfully
                if (id != 0)
                {
                    FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
                    LoadGroups();

                    MessageBox.Show("Data was saved successfully!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occured.\nData was not saved!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// A handler for filling the fillds using data of the selected DataGridView Row 
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvGroups.Rows[e.RowIndex];
            fillGroupData(row);
            fillFields(Group);
        }

        /// <summary>
        /// A handler for Enable/Disable the Group
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvGroups_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvGroups.CurrentRow;

            if(row != null)
            {
                if(row.Cells["GroupID"].Value != null)
                {
                    fillGroupData(row);
                    repository.SaveGroup(Group);
                    LoadGroups();
                }
            }
        }

        /// <summary>
        /// A handler for open modal dialog using for addin members into selected group
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Arguments</param>
        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            int GroupID = (int)(dgvGroups.CurrentRow?.Cells["GroupID"].Value ?? 0);

            if(GroupID != 0)
            {
                AddMembersToGroup addMembersDialog = new AddMembersToGroup();
                AddMembersToGroup.GroupID = GroupID;
                DialogResult dialogResult = addMembersDialog.ShowDialog(this);
                addMembersDialog.Dispose();

                if(dialogResult == DialogResult.OK)
                {
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("A Group was not selected!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// A handler for removing members from selected group
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Arguments</param>
        private void BtnRemoveMember_Click(object sender, EventArgs e)
        {
            int GroupID = (int)(dgvGroups.CurrentRow.Cells["GroupID"].Value ?? 0);

            if (GroupID != 0)
            {
                foreach (DataGridViewRow row in dgvMembers.Rows)
                {
                    if (row != null && (bool)(row.Cells[0].Value ?? false))
                    {
                        int UserID = (int)(row.Cells["UserID"].Value ?? 0);
                        repository.RemoveGroupMember(GroupID, UserID);
                    }
                }

                LoadMembers();
            }
            else
            {
                MessageBox.Show("A Group was not selected!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// A handler for reload data of the DataGridView if changes occured
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            LoadMembers();
        }

        /// <summary>
        /// A handler for clearing form fields
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Arguments</param>
        private void BtnResetData_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
        }

        private void GroupManager_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                errorProvider.SetError((sender as TextBox), "A group name must be specified!");
            }
            else
            {
                errorProvider.SetError((sender as TextBox), string.Empty);
            }
        }
    }

}
