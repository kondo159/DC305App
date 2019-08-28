using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DC305RoomManagement
{
    public partial class BookingManager : Form
    {
        private Connection conn = new Connection();

        public BookingManager()
        {
            InitializeComponent();
            dgvBookingList.AutoGenerateColumns = false;
            LoadBookingList();
        }

        private void LoadBookingList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Bookings.*,Class.Name as ClassName,Rooms.Name as RoomName,Users.Name as UserName from Bookings Left join Class on Class.ClassId=Bookings.ClassId left join Rooms on Rooms.RoomId=Bookings.RoomId left join users on Users.UserId=Bookings.UserId", conn.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dgvBookingList.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Bookings Created");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.CloseConn();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void DgvBookingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

