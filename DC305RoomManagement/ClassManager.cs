using DC305RoomManagementClassLibrary;
using DC305RoomManagementClassLibrary.Models;
using DC305RoomManagementClassLibrary.Models.Repository;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace DC305RoomManagement
{
    public partial class ClassManager : Form
    {
        private ClassEvent ClassEvent { get; set; } = new ClassEvent();

        private static Repository repository = new Repository();

        public ClassManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills form fields with data from the Class object
        /// </summary>
        /// <param name="group">Class object</param>
        private void fillFields(ClassEvent classEvent)
        {
            txtClassNameValue.Text = classEvent.ClassName;
            cbCourseTitleValue.SelectedValue = classEvent.CourseID;
            cbStaffNameValue.SelectedValue = classEvent.StaffID;
            cbGroupNameValue.SelectedValue = classEvent.GroupID;
        }

        /// <summary>
        /// Creates Class with data from form fields
        /// </summary>
        /// <returns>Class</returns>
        private void fillClass()
        {
            ClassEvent.ClassName = txtClassNameValue.Text;
            ClassEvent.CourseID = (int)(cbCourseTitleValue.SelectedValue??0);
            ClassEvent.StaffID = (int)(cbStaffNameValue.SelectedValue??0);
            ClassEvent.GroupID = (int)(cbGroupNameValue.SelectedValue??0);
        }

        /// <summary>
        /// Fills Class property by data from the row of the DataGridView
        /// </summary>
        /// <param name="row">DataGridView Row of data</param>
        private void fillCourseData(DataGridViewRow row)
        {
            ClassEvent.ClassID = (int)row.Cells["ClassID"].Value;
            ClassEvent.ClassName = row.Cells["ClassName"].Value.ToString();
            ClassEvent.CourseID = (int)(row.Cells["Course"].Value==DBNull.Value?0: (int)row.Cells["Course"].Value);
            ClassEvent.StaffID = (int)(row.Cells["Staff"].Value==DBNull.Value?0: (int)row.Cells["Staff"].Value);
            ClassEvent.GroupID = (int)(row.Cells["Group"].Value==DBNull.Value?0: (int)row.Cells["Group"].Value);
        }

        /// <summary>
        /// Loads the Classes into DataGridView
        /// </summary>
        private void LoadClasses()
        {
            // Populate Courses
            Course.ValueMember = "CourseID";
            Course.DisplayMember = "CourseName";
            Course.DataSource = repository.GetCourses();

            // Populate Staff
            Staff.ValueMember = "UserID";
            Staff.DisplayMember = "UserName";
            Staff.DataSource = repository.GetUsers(2); // 2 - RoleID of Staff

            // Populate Group
            Group.ValueMember = "GroupID";
            Group.DisplayMember = "GroupName";
            Group.DataSource = repository.GetGroups();

            dgvClasses.DataSource = repository.GetClasses();
        }

        /// <summary>
        /// Loads the Courses into ComboBox
        /// </summary>
        private void LoadCourses()
        {
            cbCourseTitleValue.ValueMember = "CourseID";
            cbCourseTitleValue.DisplayMember = "CourseName";
            cbCourseTitleValue.DataSource = repository.GetCourses();
            cbCourseTitleValue.SelectedIndex = -1;
        }

        /// <summary>
        /// Loads the Staff into ComboBox
        /// </summary>
        private void LoadStaff()
        {
            cbStaffNameValue.ValueMember = "UserID";
            cbStaffNameValue.DisplayMember = "UserName";
            cbStaffNameValue.DataSource = repository.GetUsers(2);
            cbStaffNameValue.SelectedIndex = -1;
        }

        /// <summary>
        /// Loads the Groups into ComboBox
        /// </summary>
        private void LoadGroups()
        {
            cbGroupNameValue.ValueMember = "GroupID";
            cbGroupNameValue.DisplayMember = "GroupName";
            cbGroupNameValue.DataSource = repository.GetGroups();
            cbGroupNameValue.SelectedIndex = -1;
        }

        /// <summary>
        /// Validation of the form fields
        /// </summary>
        /// <returns>Returns true if form filds are filled</returns>
        private bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtClassNameValue.Text))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// A handler for loading the Classes data into DataGridViews when the form load
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Event Arguments</param>
        private void ClassManager_Load(object sender, EventArgs e)
        {
            LoadClasses();
            LoadCourses();
            LoadStaff();
            LoadGroups();
            dgvClasses.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
        }

        /// <summary>
        /// A handler for saving the Class data into the database
        /// </summary>
        /// <param name="sender">Button "Save"</param>
        /// <param name="e">Event Arguments</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                fillClass(); // Fills the Class property by data from the form fields

                int id = repository.SaveClass(ClassEvent);

                // If data was saved successfully
                if (id != 0)
                {
                    FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
                    FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
                    LoadClasses();

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
                MessageBox.Show("All Field must be filled.\nData was not saved!", "Operation result",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// A handler for filling the fillds using data of the selected DataGridView Row 
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Event Arguments</param>
        private void DgvClasses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClasses.Rows[e.RowIndex];
            fillCourseData(row);
            fillFields(ClassEvent);
        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
            FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
            DataGridViewSelectionMode oldmode = dgvClasses.SelectionMode;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.ClearSelection();
            dgvClasses.SelectionMode = oldmode;
        }

        private void ClassManager_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                errorProvider.SetError((sender as TextBox), "A Class Name must be specified!");
            }
            else
            {
                errorProvider.SetError((sender as TextBox), string.Empty);
            }
        }

        private void BtnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.White;
        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.Black;
        }

        private void BtnDeleteGroup_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteGroup.ForeColor = Color.White;
        }

        private void BtnDeleteGroup_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteGroup.ForeColor = Color.Black;
        }

        private void BtnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.White;
        }

        private void BtnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.Black;
        }
    }
}
