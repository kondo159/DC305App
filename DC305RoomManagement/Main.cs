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
    public partial class Main : Form
    {
        string user;
        int role;
        int id;
        public Main(string user, int role,int id)
        {
            InitializeComponent();
            
            this.user = user;
            this.role = role;
            this.id = id;
            label1.Text = "Current User:";
            label2.Text = user;
            
        }
        private void DisplayInPlanel(Form page, String Header)
        {
            pnlMain.Controls.Clear();
            page.TopLevel = false;
            pnlMain.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
            lblHeader.Text = Header;
        }
        protected void BtnMenu_Click(object sender, EventArgs e)
        {
            // Loading the required form depending on which button was clicked
            switch ((sender as Button).Name)
            {
                case "btnBooking":
                    BookingManager bookingManager = new BookingManager(id, role);
                        if(role!=3)
                        DisplayInPlanel(bookingManager, "Booking Manager");
                        else
                        DisplayInPlanel(bookingManager, "List Activities");
                    break;

                case "btnRoom":
                    RoomManager roomManager = new RoomManager();
                    DisplayInPlanel(roomManager, "Room Manager");
                    break;

                case "btnClass":
                    ClassManager classManager = new ClassManager();
                    DisplayInPlanel(classManager, "Class Manager");
                    break;

                case "btnCourse":
                    CourseManager courseManager = new CourseManager();
                    DisplayInPlanel(courseManager, "Course Manager");
                    break;

                case "btnGroup":
                    GroupManager groupManager = new GroupManager();
                    DisplayInPlanel(groupManager, "Group Manager");
                    break;

                case "btnUser":
                    UserManager usermanager = new UserManager();
                    DisplayInPlanel(usermanager, "User Manager");
                    break;

                case "btnIssue":
                    IssueManager issueManager = new IssueManager();
                    DisplayInPlanel(issueManager, "Issue Manager");
                    break;

                case "btnInventory":
                    InventoryManager inventoryManager = new InventoryManager();
                    DisplayInPlanel(inventoryManager, "Inventory Manager");
                    break;

                case "btnCalendar":
                    break;

                case "btnExit":

                    Application.Exit();
                    
                    break;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            UserValidation(role);
        }
        private void UserValidation(int role)
        {
            //btnExit.Location=new Point( 0, 153);
            if(role==2)
            {
                btnUser.Visible = false;
                btnGroup.Visible = false;
                btnCourse.Visible = false;
                btnClass.Visible = false;
                btnRoom.Visible = false;
                btnInventory.Visible = false;
                btnExit.Location=new Point(0, 209);

            }
            if (role==3)
            {
                btnBooking.Text = "View Activities";
                btnIssue.Visible = false;
                btnUser.Visible = false;
                btnGroup.Visible = false;
                btnCourse.Visible = false;
                btnClass.Visible = false;
                btnRoom.Visible = false;
                btnInventory.Visible = false;
                btnExit.Location = new Point(0, 153);
            }
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void BtnBooking_MouseEnter(object sender, EventArgs e)
        {
            btnBooking.ForeColor = Color.Black;
        }

        private void BtnBooking_MouseLeave(object sender, EventArgs e)
        {
            btnBooking.ForeColor = Color.White;
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user);
            changePassword.ShowDialog();
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnIssue_MouseEnter(object sender, EventArgs e)
        {
            btnIssue.ForeColor = Color.Black;
        }

        private void BtnIssue_MouseLeave(object sender, EventArgs e)
        {
            btnIssue.ForeColor = Color.White;
        }

        private void BtnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.Black;
        }

        private void BtnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.White;
        }

        private void BtnGroup_MouseEnter(object sender, EventArgs e)
        {
            btnGroup.ForeColor = Color.Black;
        }

        private void BtnGroup_MouseLeave(object sender, EventArgs e)
        {
            btnGroup.ForeColor = Color.White;
        }

        private void BtnCourse_MouseEnter(object sender, EventArgs e)
        {
            btnCourse.ForeColor = Color.Black;
        }

        private void BtnCourse_MouseLeave(object sender, EventArgs e)
        {
            btnCourse.ForeColor = Color.White;
        }

        private void BtnClass_MouseEnter(object sender, EventArgs e)
        {
            btnClass.ForeColor = Color.Black;
        }

        private void BtnClass_MouseLeave(object sender, EventArgs e)
        {
            btnClass.ForeColor = Color.White;
        }

        private void BtnRoom_MouseEnter(object sender, EventArgs e)
        {
            btnRoom.ForeColor = Color.Black;
        }

        private void BtnRoom_MouseLeave(object sender, EventArgs e)
        {
            btnRoom.ForeColor = Color.White;
        }

        private void BtnInventory_MouseEnter(object sender, EventArgs e)
        {
            btnInventory.ForeColor = Color.Black;
        }

        private void BtnInventory_MouseLeave(object sender, EventArgs e)
        {
            btnInventory.ForeColor = Color.White;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }
    }
}
            



