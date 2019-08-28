using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DC305RoomManagement
{
    public partial class RoomManager : Form
    {
        int activeRoom=-1;
        public RoomManager()
        {
            InitializeComponent();
            LoadRoomList();
        }
        private void LoadRoomList()
        {
           Connection conn = new Connection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Rooms", conn.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);                    
                    dgvRoomList.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data");
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
        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRoomList.Rows[dgvRoomList.SelectedCells[0].RowIndex];
            activeRoom = int.Parse(row.Cells["RoomId"].Value.ToString());
            txtRoomNameValue.Text = row.Cells["Name"].Value.ToString();
            numCapacity.Value= decimal.Parse(row.Cells["Capacity"].Value.ToString());
            txtDescriptionValue.Text = row.Cells["Description"].Value.ToString();
            if(row.Cells["Enable"].Value.ToString()=="true")
             btnDisableRoom.Text = "Disable";
            else
             btnDisableRoom.Text = "Enable";

            Connection conn = new Connection();
            DataTable dt = new DataTable();
            try
            {
                
                SqlCommand cmd = new SqlCommand("SELECT Equipment.name, Equipment.description, RoomEquipment.Quantity FROM RoomEquipment LEFT JOIN Equipment ON RoomEquipment.EquipId = Equipment.EquipId Where RoomEquipment.RoomId="+activeRoom, conn.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dgvEquipments.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data");
                }
            }
            catch (Exception)
            {               
            }
            finally
            {
                conn.CloseConn();
            }
            

            btnDisableRoom.Enabled = true;
            btnCreateRoom.Enabled = false;
            btnUpdateRoom.Enabled = true;
        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            activeRoom = -1;
            txtRoomNameValue.Text = "";
            numCapacity.Value = 0;
            txtDescriptionValue.Text = "";            
            btnDisableRoom.Text = "Disable";
            btnDisableRoom.Enabled = false;
            btnCreateRoom.Enabled = true;
            btnUpdateRoom.Enabled = false;
            DataTable dt = new DataTable();
            dgvEquipments.DataSource = dt;
        }
    }    
}
