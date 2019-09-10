using DC305RoomManagementClassLibrary.Models;
using DC305RoomManagementClassLibrary.Models.Repository;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

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

        /// <summary>
        /// A handler for saving data to the database
        /// </summary>
        /// <param name="sender">Button Object</param>
        /// <param name="e">Arguments of Event</param>
        private void BtnSaveIssue_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                // If it is a new Issue
                if (Issue.IssueID == 0)
                {
                    Issue.CreatedAt = DateTime.Now;
                }

                FillIssue(); // Fills the Issue property by data from the form fields

                int id = repository.SaveIssue(Issue);
                
                // If data was saved successfully
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
            else
            {
                MessageBox.Show("All required field must be specified!", "Operation result",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fills form fields with data from the Issue object
        /// </summary>
        /// <param name="issue">Issue</param>
        private void FillFields(Issue issue)
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
        private void FillIssue()
        {
            Issue.Title = txtIssueNameValue.Text;
            Issue.Status = cbIssueStatusValue.Text;
            Issue.Description = txtDescriptionValue.Text;
            Issue.RoomID = (int)(cbRoomName.SelectedValue ?? 0);
        }

        /// <summary>
        /// Validation of the form fields
        /// </summary>
        /// <returns>Returns true if form filds are filled</returns>
        private bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(cbRoomName.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescriptionValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(cbIssueStatusValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtIssueNameValue.Text))
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
        /// Loads the list of the Rooms into ComboBox (cbRoomName)
        /// </summary>
        private void LoadRoomList()
        {
            cbRoomName.ValueMember = "RoomID";
            cbRoomName.DisplayMember = "RoomName";
            cbRoomName.DataSource = repository.GetRooms();
            cbRoomName.SelectedIndex = -1;
        }

        /// <summary>
        /// A handler of the main form loading. 
        /// Loading Issues and Rooms list into controls of the form.
        /// </summary>
        /// <param name="sender">Main Form</param>
        /// <param name="e">Arguments</param>
        private void IssueManager_Load(object sender, EventArgs e)
        {
            dgvIssues.ClearSelection();
            LoadIssueList();
            LoadRoomList();
            dgvIssues.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F);
        }

        /// <summary>
        /// A handler of the CellDoubleClick Event.
        /// Data of selected Row in DataGridView insert into form fields.
        /// </summary>
        /// <param name="sender">Row of the DataGridView</param>
        /// <param name="e">Arguments</param>
        private void DgvIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvIssues.Rows[e.RowIndex];
            fillIssueData(row);
            FillFields(Issue);
        }

        /// <summary>
        /// Fills Issue property by data from the row of the DataGridView
        /// </summary>
        /// <param name="row">DataGridView Row of data</param>
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
        
        /// <summary>
        /// A handler for filtering rows of DataGridView by Created Date of Issue 
        /// depends on started and ended dates. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFilterDate_Click(object sender, EventArgs e)
        {
            Button filter = (sender as Button);
            if(filter.Text == "Filter")
            {
                (dgvIssues.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                    "CreatedAt >= '{0}' and CreatedAt < '{1}'", 
                    dtpFrom.Value.Date, dtpTo.Value.AddDays(1).Date);
                filter.Text = "Clear Filter";
            }
            else
            {
                (dgvIssues.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                filter.Text = "Filter";
            }
        }

        /// <summary>
        /// A handler for printing data of DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();            
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            // preview the assigned document or you can create a different previewButton for it
            printPrvDlg.Document = printDocument1;
            printPrvDlg.ShowDialog();

            printDocument1.DocumentName = "Issues Report";
            printDlg.Document = printDocument1;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }
        /// <summary>
        /// Method to construct the file that will be printed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            int cHeight = dgvIssues.Rows[0].Height;//Height of the cells

            int x = 100;//start position for the first collumn

            for (int c = 0; c < dgvIssues.Columns.Count; c++)
            {
                int y = 100;//reset possition to the top
                if (dgvIssues.Columns[c].Visible)
                {
                    //Draws a rectangle  
                    e.Graphics.DrawRectangle(Pens.Black, x, y,
                    dgvIssues.Columns[c].Width, cHeight);


                    //Fills the above drawn rectangle with a light gray colour just to distinguish the header 
                    e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y,
                        dgvIssues.Columns[c].Width, cHeight));

                    //Draws a text inside the above drawn rectangle whose value is same of the first column. 

                    e.Graphics.DrawString(dgvIssues.Columns[c].HeaderText,
                         dgvIssues.Font, Brushes.Black, new RectangleF(x, y,
                         dgvIssues.Columns[c].Width, cHeight));

                    for (int r = 0; r < dgvIssues.Rows.Count; r++)
                    {
                        int rowheight = dgvIssues.Rows[r].Height;
                        int colwidth = dgvIssues.Columns[0].Width;
                        y += rowheight; //increment the y co-ordinate 
                        //Draws a rectangle 
                        e.Graphics.DrawRectangle(Pens.Black, x, y, colwidth, rowheight);
                        //Insert data inside the rectangle 
                        e.Graphics.DrawString(dgvIssues.Rows[r].Cells[c].FormattedValue.ToString(),
                         dgvIssues.Font, Brushes.Black, new RectangleF(x, y, colwidth, rowheight));
                    }
                    x += dgvIssues.Columns[c].Width;//move to the next collumn
                }
            }
        }   
        /// <summary>
        /// Checks if the field was filled
        /// </summary>
        /// <param name="sender">Field</param>
        /// <param name="e">Event Arguments</param>
        private void IssueManager_Validating(object sender, CancelEventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "ComboBox":
                    string cbMsg = (sender as ComboBox).Name == "cbRoomName" ?
                        "A room name must be specified!"
                        : "An issue status must be specified!";

                    if (string.IsNullOrWhiteSpace((sender as ComboBox).Text))
                    {
                        errorProvider.SetError((sender as ComboBox), cbMsg);
                    }
                    else
                    {
                        errorProvider.SetError((sender as ComboBox), string.Empty);
                    }

                    break;

                case "TextBox":
                    if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
                    {
                        errorProvider.SetError((sender as TextBox), "An issue title must be specified!");
                    }
                    else
                    {
                        errorProvider.SetError((sender as TextBox), string.Empty);
                    }

                    break;
            }
        }

        private void BtnCreateIssue_MouseEnter(object sender, EventArgs e)
        {
            btnCreateIssue.ForeColor = Color.White;
        }

        private void BtnCreateIssue_MouseLeave(object sender, EventArgs e)
        {
            btnCreateIssue.ForeColor = Color.Black;
        }

        private void BtnFilterDate_MouseEnter(object sender, EventArgs e)
        {
            btnFilterDate.ForeColor = Color.White;
        }

        private void BtnFilterDate_MouseLeave(object sender, EventArgs e)
        {
            btnFilterDate.ForeColor = Color.Black;
        }

        private void BtnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.White;
        }

        private void BtnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.Black;
        }

        
    }
}
