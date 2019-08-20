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
//COME BACK TO REVISE THE SAVE METHOD 
namespace DC305RoomManagement
{
    public partial class RoomManager : Form
    { //variable to store the active room in the form, -1 it means the form is empty
        int activeRoom=-1;
        Connection conn = new Connection();
        List<RoomEquip> roomEquips = new List<RoomEquip>();
        public RoomManager()
        {
            InitializeComponent();
            //fill the table of Rooms
            LoadRoomList();
        }
        private void LoadRoomList()
        {
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
        //Fuction to Edit the selected room on the table, bring the information to the form
        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            //bring the room information to the from
            DataGridViewRow row = dgvRoomList.Rows[dgvRoomList.SelectedCells[0].RowIndex];
            activeRoom = int.Parse(row.Cells["RoomId"].Value.ToString());
            txtRoomNameValue.Text = row.Cells["RoomName"].Value.ToString();
            numCapacity.Value= decimal.Parse(row.Cells["RoomCapacity"].Value.ToString());
            txtDescriptionValue.Text = row.Cells["RoomDescription"].Value.ToString();
            if(row.Cells["RoomEnable"].Value.ToString()=="true")
             btnDisableRoom.Text = "Disable";
            else
             btnDisableRoom.Text = "Enable";
            //bring the equipment of the room to the equipment table            
            LoadRoomEquip();

            ///change the active buttons
            btnDisableRoom.Enabled = true;
            btnCreateRoom.Enabled = false;
            btnUpdateRoom.Enabled = true;
        }
        public void LoadRoomEquip()
        {
            DataTable dt = new DataTable();
            dgvEquipments.DataSource = dt;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Equipment.EquipId,Equipment.Name, Equipment.Description, RoomEquipment.Quantity FROM RoomEquipment LEFT JOIN Equipment ON RoomEquipment.EquipId = Equipment.EquipId Where RoomEquipment.RoomId=" + activeRoom, conn.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);    
                   for(int c=0;c< dt.Rows.Count;c++)
                    {
                        RoomEquip equip = new RoomEquip();
                        equip.EquipId=Convert.ToInt32(dt.Rows[c]["EquipId"].ToString());
                        equip.Name = dt.Rows[c]["Name"].ToString();
                        equip.Quantity = Convert.ToInt32(dt.Rows[c]["Quantity"].ToString());
                        equip.Desc = dt.Rows[c]["Description"].ToString();
                        roomEquips.Add(equip);

                    }
                    dgvEquipments.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Equipments Linked with this Room");
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
        //reset all the form and the equipment table
        private void BtnResetData_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        public void ResetForm()
        {
            activeRoom = -1;
            roomEquips.Clear();
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

        private void BtnRemoveEquipment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to remove this Equipment?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                /* try
                 {
                     string equipId = dgvEquipments.Rows[dgvEquipments.SelectedCells[0].RowIndex].Cells["EquipId"].Value.ToString();
                     SqlCommand cmd = new SqlCommand("DELETE FROM RoomEquipment  Where EquipId =" + equipId + "AND RoomId=" + activeRoom, conn.OpenConn());
                     cmd.ExecuteNonQuery();

                 }
                 catch (Exception)
                 {
                     throw;
                 }
                 finally
                 {
                     conn.CloseConn();
                     LoadRoomEquip();
                 }*/
                string equipId = dgvEquipments.Rows[dgvEquipments.SelectedCells[0].RowIndex].Cells["EquipId"].Value.ToString();
                for(int i=0;i< roomEquips.Count; i++)
                {
                    if (roomEquips[i].EquipId ==Convert.ToInt32( equipId))
                    {
                        roomEquips.RemoveAt(i);
                        dgvEquipments.Rows.RemoveAt(dgvEquipments.SelectedCells[0].RowIndex);
                        break;
                    }
                }
            }           
        }

        private void BtnCreateRoom_Click(object sender, EventArgs e)
        {
            SqlConnection opencon=conn.OpenConn();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Rooms (Name,Capacity,Description,Enable) values(@name,@cap,@desc,@enable);Select SCOPE_IDENTITY();", opencon);
                cmd.Parameters.AddWithValue("@name", txtRoomNameValue.Text);
                cmd.Parameters.AddWithValue("@cap", Convert.ToInt32(numCapacity.Text));
                cmd.Parameters.AddWithValue("@desc", txtDescriptionValue.Text);
                cmd.Parameters.AddWithValue("@enable", btnDisableRoom.Text == "Disable"?true:false);                
                activeRoom = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < roomEquips.Count; i++)
                {
                    cmd = new SqlCommand("Insert into RoomEquipment (RoomId,EquipId,Quantity) values(@room,@equip,@quantity)", opencon);
                    cmd.Parameters.AddWithValue("@room", activeRoom);
                    cmd.Parameters.AddWithValue("@equip", roomEquips[i].EquipId);
                    cmd.Parameters.AddWithValue("@quantity", roomEquips[i].Quantity);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.CloseConn();
                ResetForm();
                LoadRoomList();
            }
        }
    }    
}
