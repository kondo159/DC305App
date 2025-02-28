﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Drawing;


namespace DC305RoomManagement
{
    public partial class RoomManager : Form
    { 
        private int activeRoom=-1;//variable to store the active room in the form, -1 it means the form is empty
        private Connection conn = new Connection();
        private List<RoomEquip> roomEquips = new List<RoomEquip>();
        private List<RoomEquip> oldRoomEquips = new List<RoomEquip>();
        public RoomManager()
        {
            InitializeComponent();
            //fill the table of Rooms
            LoadRoomList();
            //initializing the datagrid
            dgvEquipments.AutoGenerateColumns = false;//prevent to reset the columns layout
            DataTable dt = new DataTable();
            dgvEquipments.DataSource = dt;
        }
        //method to load the list of Rooms
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
                    MessageBox.Show("No Rooms Created");
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
            //Clear form before include the information
            ResetForm();
            //bring the room information to the from
            DataGridViewRow row = dgvRoomList.Rows[dgvRoomList.SelectedCells[0].RowIndex];
            activeRoom = int.Parse(row.Cells["RoomId"].Value.ToString());
            txtRoomNameValue.Text = row.Cells["RoomName"].Value.ToString();
            numCapacity.Value= decimal.Parse(row.Cells["RoomCapacity"].Value.ToString());
            txtDescriptionValue.Text = row.Cells["RoomDescription"].Value.ToString();
            if(row.Cells["RoomEnable"].Value.ToString()==true.ToString())
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
        //Method to load the list of Equipment of the selected room and populate the list object to control the objects before save
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
                    //populating the list object to control the equipments before save 
                   for(int c=0;c< dt.Rows.Count;c++)
                    {
                        RoomEquip equip = new RoomEquip();                        
                        equip.EquipId=Convert.ToInt32(dt.Rows[c]["EquipId"].ToString());
                        equip.Name = dt.Rows[c]["Name"].ToString();
                        equip.Quantity = Convert.ToInt32(dt.Rows[c]["Quantity"].ToString());
                        equip.Desc = dt.Rows[c]["Description"].ToString();
                        roomEquips.Add(equip);
                        RoomEquip oldEquip = new RoomEquip(equip.EquipId,equip.Name,equip.Quantity,equip.Desc);
                        oldRoomEquips.Add(oldEquip);
                    }
                   //populating datagrid
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
        //reset all the form and the equipment table by button
        private void BtnResetData_Click(object sender, EventArgs e)
        {
            ResetForm();
            DataGridViewSelectionMode oldmode = dgvEquipments.SelectionMode;
            dgvEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipments.ClearSelection();
            dgvEquipments.SelectionMode = oldmode;
        }
        
        public void ResetForm()//method to reset the form
        {
            activeRoom = -1;
            roomEquips.Clear();
            oldRoomEquips.Clear();
            txtRoomNameValue.Text = "";
            numCapacity.Value = 1;
            errorProvider1.SetError(txtRoomNameValue, "");
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
                string equipId = dgvEquipments.Rows[dgvEquipments.SelectedCells[0].RowIndex].Cells["EquipId"].Value.ToString();
                //for used to find and remove the equiment from the list and from the datagrid
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
            if (FieldValidation()) { 
            //Variable created to hold the connection Open until the end of the function
            SqlConnection opencon=conn.OpenConn();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Rooms (Name,Capacity,Description,Enable) values(@name,@cap,@desc,@enable);Select SCOPE_IDENTITY();", opencon);
                cmd.Parameters.AddWithValue("@name", txtRoomNameValue.Text);
                cmd.Parameters.AddWithValue("@cap", Convert.ToInt32(numCapacity.Text));
                cmd.Parameters.AddWithValue("@desc", txtDescriptionValue.Text);
                cmd.Parameters.AddWithValue("@enable", btnDisableRoom.Text == "Disable"?true:false);
                //ExecuteScaler used to get the ID of the new room
                activeRoom = Convert.ToInt32(cmd.ExecuteScalar());
                //for used to insert all the Equipments to the room
                for (int i = 0; i < roomEquips.Count; i++)
                {
                    cmd = new SqlCommand("Insert into RoomEquipment (RoomId,EquipId,Quantity) values(@room,@equip,@quantity)", opencon);
                    cmd.Parameters.AddWithValue("@room", activeRoom);
                    cmd.Parameters.AddWithValue("@equip", roomEquips[i].EquipId);
                    cmd.Parameters.AddWithValue("@quantity", roomEquips[i].Quantity);
                    cmd.ExecuteNonQuery();
                }

            }
            catch(Exception)
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

        private void BtnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (FieldValidation())
            {

            SqlConnection opencon = conn.OpenConn();
            try
            {
                    //Command to update the information of the room
                SqlCommand cmd = new SqlCommand("Update Rooms Set Name=@name, Capacity=@cap, Description=@desc ,Enable=@enable where roomId=@roomid", opencon);
                cmd.Parameters.AddWithValue("@name", txtRoomNameValue.Text);
                cmd.Parameters.AddWithValue("@cap", Convert.ToInt32(numCapacity.Text));
                cmd.Parameters.AddWithValue("@desc", txtDescriptionValue.Text);
                cmd.Parameters.AddWithValue("@enable", btnDisableRoom.Text == "Disable" ? true : false);
                cmd.Parameters.AddWithValue("@roomid", activeRoom); 
                cmd.ExecuteNonQuery();                                            
                
                //For to update the linked Equipments
                for (int c = 0; c < oldRoomEquips.Count; c++)
                {
                    bool exist = false;
                    for (int i = 0; i < roomEquips.Count; i++)
                    {
                        if(oldRoomEquips[c].EquipId==roomEquips[i].EquipId)
                        {
                            exist = true;
                            if(oldRoomEquips[c].Quantity != roomEquips[i].Quantity)//will update all equipment that suffer any alterations on qunatity
                            {
                                cmd = new SqlCommand("Update RoomEquipment Set Quantity=@quantity where roomId=@roomid AND EquipId=@equipid", opencon);
                                cmd.Parameters.AddWithValue("@quantity", roomEquips[i].Quantity);
                                cmd.Parameters.AddWithValue("@roomid", activeRoom);
                                cmd.Parameters.AddWithValue("@equipid", roomEquips[i].EquipId);
                                cmd.ExecuteNonQuery();
                            }
                            roomEquips.RemoveAt(i);    
                            break;
                        }
                    }
                    if (!exist)//will delete all the equipment that has been removed from the room
                    {
                        cmd = new SqlCommand("DELETE FROM RoomEquipment where roomId=@roomid AND EquipId=@equipid", opencon);
                        cmd.Parameters.AddWithValue("@roomid", activeRoom);
                        cmd.Parameters.AddWithValue("@equipid", oldRoomEquips[c].EquipId);
                        cmd.ExecuteNonQuery();
                    }
                }
                for (int i = 0; i < roomEquips.Count; i++)//insert all the new equipment for that room
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

        private void BtnAddEquipment_Click(object sender, EventArgs e)
        {                        
            using (RoomManagerAddEquip addEquipWin = new RoomManagerAddEquip())//opens another window to select the equipment
            {
                var result = addEquipWin.ShowDialog();
                if (result == DialogResult.OK && addEquipWin.EquipId!= 0)
                {
                    
                    DataTable dt = dgvEquipments.DataSource as DataTable;
                    if (dgvEquipments.Rows.Count == 0)//if table dont have row is necessary define the columns for the datatable
                    {
                        dt.Columns.Add("EquipId");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("Description");
                    }

                    bool exist = false;
                    int maxEquip = 0;

                    for (int i = 0; i < roomEquips.Count; i++)
                    {
                        if(roomEquips[i].EquipId==addEquipWin.EquipId)
                        {
                            maxEquip = addEquipWin.Maxquantity;//define a base maxquantity of equip can be linked to this room
                            for (int x = 0; x < oldRoomEquips.Count; x++)//for used to check if equipment was already linked if so it will define what is the maxquantity for this room
                            {
                                if (oldRoomEquips[x].EquipId == addEquipWin.EquipId) {
                                    maxEquip = addEquipWin.Maxquantity + oldRoomEquips[x].Quantity;
                                    break;
                                }

                            }

                            for (int c = 0; c < dt.Rows.Count; c++) {//finding equipment on the table if finds it validates and updated the quantity
                                if(dt.Rows[c]["EquipId"].ToString()== addEquipWin.EquipId.ToString())
                                {
                                    int qnt = Convert.ToInt32(dt.Rows[c]["Quantity"].ToString());
                                    qnt+= addEquipWin.Quantity;                                    
                                    if (maxEquip >= qnt)
                                    {
                                        dt.Rows[c]["Quantity"] = qnt;
                                        roomEquips[i].Quantity = qnt;
                                    }
                                    else {
                                        MessageBox.Show("Equipment couldnt be add because the max number is "+maxEquip, "Equip not available",MessageBoxButtons.OK);
                                    }                                    
                                    break;
                                }
                                  
                            }
                            exist = true;
                            break;
                        }

                    }
                    if (!exist)//if equip does not exist on the table it will be add to the datagrid and to the RoomEquips Object
                    {
                        roomEquips.Add(new RoomEquip(addEquipWin.EquipId, addEquipWin.Name, addEquipWin.Quantity, addEquipWin.Desc));
                        DataRow equip = dt.NewRow();
                        equip["EquipId"] = addEquipWin.EquipId;
                        equip["Name"] = addEquipWin.Name;                        
                        equip["Quantity"] = addEquipWin.Quantity;
                        equip["Description"] = addEquipWin.Desc;
                        dt.Rows.Add(equip);
                    }                    
                }
            }
        }
        private bool FieldValidation()
        {
            if (txtRoomNameValue.Text == "")
            {
                errorProvider1.SetError(txtRoomNameValue,"Name must be inserted");
                return false;
            }
            errorProvider1.SetError(txtRoomNameValue, "");
            return true;
        }

        private void BtnDisableRoom_Click(object sender, EventArgs e)
        {
            if(btnDisableRoom.Text =="Enable")
                btnDisableRoom.Text = "Disable";
            else
                btnDisableRoom.Text = "Enable";
        }

        private void BtnCreateRoom_MouseEnter(object sender, EventArgs e)
        {
            btnCreateRoom.ForeColor = Color.White;
            btnCreateRoom.BackColor = Color.DodgerBlue;
        }

        private void BtnCreateRoom_MouseLeave(object sender, EventArgs e)
        {
            btnCreateRoom.ForeColor = Color.Black;
            btnCreateRoom.BackColor = Color.Gainsboro;
        }

        private void BtnDisableRoom_MouseEnter(object sender, EventArgs e)
        {
            btnDisableRoom.ForeColor = Color.White;
            btnDisableRoom.BackColor = Color.DodgerBlue;
        }

        private void BtnDisableRoom_MouseLeave(object sender, EventArgs e)
        {
            btnDisableRoom.ForeColor = Color.Black;
            btnDisableRoom.BackColor = Color.Gainsboro;
        }

        private void BtnUpdateRoom_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateRoom.ForeColor = Color.White;
            btnUpdateRoom.BackColor = Color.DodgerBlue;
        }

        private void BtnUpdateRoom_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateRoom.ForeColor = Color.Black;
            btnUpdateRoom.BackColor = Color.Gainsboro;
        }

        private void BtnResetData_MouseEnter(object sender, EventArgs e)
        {
            btnResetData.ForeColor = Color.White;
            btnResetData.BackColor = Color.DodgerBlue;
        }

        private void BtnResetData_MouseLeave(object sender, EventArgs e)
        {
            btnResetData.ForeColor = Color.Black;
            btnResetData.BackColor = Color.Gainsboro;
        }

        private void BtnAddEquipment_MouseEnter(object sender, EventArgs e)
        {
            btnAddEquipment.ForeColor = Color.White;
        }

        private void BtnAddEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnAddEquipment.ForeColor = Color.Black;
        }

        private void BtnRemoveEquipment_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveEquipment.ForeColor = Color.White;
        }

        private void BtnRemoveEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveEquipment.ForeColor = Color.Black;
        }

        private void BtnEditRoom_MouseEnter(object sender, EventArgs e)
        {
            btnEditRoom.ForeColor = Color.White;
        }

        private void BtnEditRoom_MouseLeave(object sender, EventArgs e)
        {
            btnEditRoom.ForeColor = Color.Black;
        }

        private void RoomManager_Load(object sender, EventArgs e)
        {
            dgvEquipments.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
        }
    }    
}
