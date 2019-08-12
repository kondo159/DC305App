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
        public Main()
        {
            InitializeComponent();
            
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
                    break;
                case "btnGroup":
                    break;
                case "btnUser":
                    Login login = new Login();
                    DisplayInPlanel(login, "User Manager");
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

        }
    }
}
