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
    public partial class CourseManager : Form
    {
        private Course Course { get; set; } = new Course();

        private static Repository repository = new Repository();

        public CourseManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills form fields with data from the Course object
        /// </summary>
        /// <param name="group">Group object</param>
        private void fillFields(Course course)
        {
            txtCourseNameValue.Text = course.CourseName;
            txtDescriptionValue.Text = course.Description;
            txtDuration.Text = course.Duration;
            setLevelField(course.Level);
        }

        private void setLevelField(string level)
        {
            gbLevels.Controls.Cast<RadioButton>()
                .Where(rb => rb.Text == level).FirstOrDefault().Checked = true;
        }

        private string getLevelField()
        {
            var radioButton = gbLevels.Controls.Cast<RadioButton>()
                .Where(rb => rb.Checked is true).FirstOrDefault();
            
            return radioButton.Text;
        }

        /// <summary>
        /// Creates Course with data from form fields
        /// </summary>
        /// <returns>Course</returns>
        private void fillCourse()
        {
            Course.CourseName = txtCourseNameValue.Text;
            Course.Description = txtDescriptionValue.Text;
            Course.Duration = txtDuration.Text;
            Course.Level = getLevelField();
        }

        /// <summary>
        /// Fills Course property by data from the row of the DataGridView
        /// </summary>
        /// <param name="row">DataGridView Row of data</param>
        private void fillCourseData(DataGridViewRow row)
        {
            Course.CourseID = (int)row.Cells["CourseID"].Value;
            Course.CourseName = row.Cells["CourseName"].Value.ToString();
            Course.Description = row.Cells["Description"].Value.ToString();
            Course.Duration = row.Cells["Duration"].Value.ToString();
            Course.Level = row.Cells["Level"].Value.ToString();
        }

        /// <summary>
        /// Loads the Courses into DataGridView
        /// </summary>
        private void LoadCourses()
        {
            dgvCourses.DataSource = repository.GetCourses();
        }

        /// <summary>
        /// Validation of the form fields
        /// </summary>
        /// <returns>Returns true if form filds are filled</returns>
        private bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtCourseNameValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescriptionValue.Text))
            {
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// A handler for loading the Courses data into DataGridViews when the form load
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Event Arguments</param>
        private void CourseManager_Load(object sender, EventArgs e)
        {
            LoadCourses();
            dgvCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F);
        }

        /// <summary>
        /// A handler for saving the Course data into the database
        /// </summary>
        /// <param name="sender">Button "Save"</param>
        /// <param name="e">Event Arguments</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                fillCourse(); // Fills the Course property by data from the form fields

                int id = repository.SaveCourse(Course);

                // If data was saved successfully
                if (id != 0)
                {
                    FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
                    FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
                    LoadCourses();

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
        private void DgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
            fillCourseData(row);
            fillFields(Course);
        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFields(pnlMainContent, typeof(TextBox));
            FormHelper.ClearFields(pnlMainContent, typeof(ComboBox));
            DataGridViewSelectionMode oldmode = dgvCourses.SelectionMode;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.ClearSelection();
            dgvCourses.SelectionMode = oldmode;
        }

        private void CourseManager_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                errorProvider.SetError((sender as TextBox), "A Course Name must be specified!");
            }
            else
            {
                errorProvider.SetError((sender as TextBox), string.Empty);
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

        private void BtnResetData_MouseEnter(object sender, EventArgs e)
        {
            btnResetData.ForeColor = Color.White;
        }

        private void BtnResetData_MouseLeave(object sender, EventArgs e)
        {
            btnResetData.ForeColor = Color.Black;
        }
    }
}
