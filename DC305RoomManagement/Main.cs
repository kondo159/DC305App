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
        public Main(string user, int role)
        {
            InitializeComponent();
            
            this.user = user;
            this.role = role;
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
                    BookingManager bookingManager = new BookingManager();
                    DisplayInPlanel(bookingManager, "Booking Manager");
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
    }
}


