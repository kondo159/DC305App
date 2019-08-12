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
        private void BtnBooking_Click(object sender, EventArgs e)
        {
            BookingManager bookingManager = new BookingManager();

            DisplayInPlanel(bookingManager, "Booking Manager");
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DisplayInPlanel(login, "User Manager");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
