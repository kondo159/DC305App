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
    public partial class AddMembersToGroup : Form
    {
        public static int GroupID { get; set; }

        private static Repository repository = new Repository();

        public AddMembersToGroup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads Users by the RoleID from the database to DataGridView
        /// </summary>
        /// <param name="RoleID">Int RoleID (Admin, Staff, Student)</param>
        private void LoadUsers(int RoleID = 0)
        {
            dgvUsers.DataSource = repository.GetUsers(RoleID);
        }

        /// <summary>
        /// A handler for loading users of particular group occurs when form load
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Event Arguments</param>
        private void AddMembersToGroup_Load(object sender, EventArgs e)
        {
            LoadUsers(1); // Get Students
        }

        /// <summary>
        /// Adds members to the group
        /// </summary>
        /// <param name="sender">Button "Add"</param>
        /// <param name="e">Event Arguments</param>
        private void BtnAddMembers_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvUsers.Rows)
            {
                if(row != null && (bool)(row.Cells[0].Value ?? false))
                {
                    repository.SaveGroupMember(GroupID, (int)row.Cells["UserID"].Value);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// A handler for clearing the form fields
        /// </summary>
        /// <param name="sender">Button "Reset"</param>
        /// <param name="e">Event Arguments</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row != null && (bool)(row.Cells[0].Value ?? false))
                {
                    row.Cells[0].Value = false;
                }
            }
        }
    }
}
