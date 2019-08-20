using DC305RoomManagementClassLibrary.Models;
using DC305RoomManagementClassLibrary.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC305RoomManagement
{
    public partial class IssueManager : Form
    {
        private Issue Issue { get; set; } = new Issue();

        private static Repository repository = new Repository();

        public IssueManager()
        {
            InitializeComponent();
        }
        // TODO: Update Issue Data
        // TODO: Filter Issue By Date
        // TODO: Print Issue

        private void BtnSaveIssue_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                int roomID = (int)cbRoomName.SelectedValue;

                if (Issue.IssueID == 0)

                {
                    Issue.CreatedAt = DateTime.Now;
                    Issue.RoomID = roomID;
                }

                fillIssue();

                int id = repository.SaveIssue(Issue);
                if (id != 0)
                {
                    FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
                    FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
                    LoadIssueList();
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
        /// Fills form fields with data
        /// </summary>
        /// <param name="issue">Issue</param>
        private void fillFields(Issue issue)
        {
            txtIssueNameValue.Text = issue.Title;
            txtDescriptionValue.Text = issue.Description;
            cbIssueStatusValue.SelectedIndex = cbIssueStatusValue.FindStringExact(issue.Status);
            cbRoomName.SelectedValue = issue.RoomID;

        }

        /// <summary>
        /// Creates Issue with data from form fields
        /// </summary>
        /// <returns>Issue</returns>
        private void fillIssue()
        {
            Issue.Title = txtIssueNameValue.Text;
            Issue.Status = cbIssueStatusValue.Text;
            Issue.Description = txtDescriptionValue.Text;
            Issue.RoomID = (int)cbRoomName.SelectedValue;
        }

        private bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtDescriptionValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(cbIssueStatusValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescriptionValue.Text))
            {
                valid = false;
            }

            return valid;

        }

        /// <summary>
        /// Loads the list of the Issues into DataGridView
        /// </summary>
        private void LoadIssueList()
        {
            Room.ValueMember = "RoomID";
            Room.DisplayMember = "RoomName";
            Room.DataSource = repository.GetRooms();
            dgvIssues.DataSource = repository.GetIssues();
        }

        /// <summary>
        /// Loads the list of the Enable Rooms into ComboBox (cbRoomName)
        /// </summary>
        private void LoadRoomList()
        {
            cbRoomName.ValueMember = "RoomID";
            cbRoomName.DisplayMember = "RoomName";
            cbRoomName.DataSource = repository.GetRooms();
            cbRoomName.SelectedIndex = -1;
        }

        private void IssueManager_Load(object sender, EventArgs e)
        {
            LoadIssueList();
            LoadRoomList();
        }

        private void DgvIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvIssues.Rows[e.RowIndex];
            fillIssueData(row);
            fillFields(Issue);
        }

        private void fillIssueData(DataGridViewRow row)
        {
            Issue.IssueID = (int)row.Cells["IssueID"].Value;
            Issue.Title = row.Cells["IssueName"].Value.ToString();
            Issue.Status = row.Cells["Status"].Value.ToString();
            Issue.Description = row.Cells["Description"].Value.ToString();
            Issue.CreatedAt = (DateTime)row.Cells["CreatedAt"].Value;
            Issue.ClosedAt = (DateTime)row.Cells["ClosedAt"].Value;
            Issue.RoomID = (int)row.Cells["Room"].Value;
        }

        private void DgvIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
