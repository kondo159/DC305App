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
        private int userId = 6;
        private int userRole = 1;//1=admin 2= staff 3=student
        public BookingManager()
        {
            InitializeComponent();
        }
        private void BookingManager_Load(object sender, EventArgs e)
        {
            dgvBookingList.AutoGenerateColumns = false;
            LoadComboBox("Select * from Rooms where Enable=1", "RoomId", cboxRoom);
            LoadComboBox("Select * from Users where Role=2", "UserId", cboxStaff);
            LoadComboBox("Select ClassId,Name from Class", "ClassId", cboxClass);
            ResetForm();
            if (userRole == 1)                            
                cboxStaff.SelectedValueChanged += new EventHandler(CboxStaff_SelectedIndexChanged);
            
            if (userRole == 2)                           
                SetStaffCUDMenu();
            
            
        }
        /// <summary>
        /// Method to populate the datagridview 
        /// </summary>
        private void LoadBookingList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Bookings.*,Class.Name as ClassName,Class.Teacher,t.Name as teacherName,Rooms.Name as RoomName,Users.Name as UserName from Bookings Left join Class on Class.ClassId=Bookings.ClassId left join Rooms on Rooms.RoomId=Bookings.RoomId left join users on Users.UserId=Bookings.UserId left join users t on T.UserId=Class.Teacher", conn.OpenConn());                
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
        /// <summary>
        /// General method to populate ComboBox 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="valueMember"></param>
        /// <param name="cb"></param>
        private void LoadComboBox(String sqlCommand, string valueMember, ComboBox cb)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, conn.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                cb.DisplayMember = "Name";
                cb.ValueMember = valueMember;
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    DataRow select = dt.NewRow();
                    select["Name"] = "-Select-";
                    select[valueMember] = "0";
                    dt.Rows.InsertAt(select, 0);
                    cb.DataSource = dt;
                }
                else
                {
                    dt.Load(reader);
                    DataRow select = dt.NewRow();
                    select["Name"] = "-No Classes-";
                    select[valueMember] = "0";
                    dt.Rows.InsertAt(select, 0);
                    cb.DataSource = dt;
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
        /// <summary>
        /// Method to popuate ComboBox with classes linked with the selected Staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxStaff.SelectedValue.ToString() != "0")
            {
                string staffId = cboxStaff.SelectedValue.ToString();
                string sqlCommand = "Select ClassId,Name from Class where Teacher=" + staffId + " and Active=1";
                LoadComboBox(sqlCommand, "ClassId", cboxClass);
            }
        }
        
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert INTO Bookings (ClassId,RoomId,UserId,SDateTime,EDateTime) values(@class,@room,@user,@Sdate,@Edate)", conn.OpenConn());
            cmd.Parameters.AddWithValue("@class", Convert.ToInt32(cboxClass.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@room", Convert.ToInt32(cboxRoom.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@user",7);
            cmd.Parameters.AddWithValue("@Sdate", dtpStart.Value.ToString());
            cmd.Parameters.AddWithValue("@Edate", dtpEnd.Value.ToString());
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            LoadBookingList();
        }

        private void rdoFilter_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnFilter.Enabled = true;
            cballdates.Visible = true;
            if (userRole == 2)
            {
                cboxStaff.SelectedValueChanged += new EventHandler(CboxStaff_SelectedIndexChanged);
                cboxStaff.Enabled = true;
            }
                

        }

        private void RdoCUD_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();            
            btnFilter.Enabled = false;
            cballdates.Visible = false;
            if (userRole == 2)
            {                
                cboxStaff.SelectedValueChanged -= new EventHandler(CboxStaff_SelectedIndexChanged);
                SetStaffCUDMenu();
            }
            
            
        }
        private void SetStaffCUDMenu()
        {
            ResetForm();
            cboxStaff.SelectedValue = userId;            
            cboxStaff.Enabled = false;
            string sqlCommand = "Select ClassId,Name from Class where Teacher=" + userId + " and Active=1";
            LoadComboBox(sqlCommand, "ClassId", cboxClass);
            
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string commandString = "Select Bookings.*,Class.Name as ClassName,Class.Teacher,t.Name as teacherName,Rooms.Name as RoomName,Users.Name as UserName " +
            "from Bookings " +
            "Left join Class on Class.ClassId = Bookings.ClassId " +
            "left join Rooms on Rooms.RoomId = Bookings.RoomId " +
            "left join users on Users.UserId = Bookings.UserId " +
            "left join users t on T.UserId = Class.Teacher "+
            "where ((@room = 0 AND Bookings.RoomId is NOT NULL) OR (@room != 0 AND Bookings.RoomId=@room))";
            if (!cballdates.Checked)
            {
                commandString += "AND (Bookings.SDateTime BETWEEN @Stime AND @Etime)";
                commandString += " OR Bookings.EDateTime BETWEEN @Stime AND @Etime";
            }
                

            commandString += " AND ((@class = 0 AND Bookings.ClassId is NOT NULL) OR (@class != 0 AND Bookings.ClassId=@class))";
            SqlCommand cmd = new SqlCommand(commandString, conn.OpenConn());
            cmd.Parameters.AddWithValue("@room", cboxRoom.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Stime", dtpStart.Value.ToString());
            cmd.Parameters.AddWithValue("@Etime", dtpEnd.Value.ToString());
            cmd.Parameters.AddWithValue("@class", cboxClass.SelectedValue.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                dt.Load(reader);
                dgvBookingList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Bookings to list");
            }
            conn.CloseConn();
        }

        private void Cballdates_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = !dtpStart.Enabled;
            dtpEnd.Enabled = !dtpEnd.Enabled;
        }

        private void ResetForm()
        {
            LoadBookingList();
            cboxRoom.SelectedIndex = 0;
            if(userRole==2 && rdoFilter.Checked || userRole==1)
                cboxStaff.SelectedIndex = 0;
            cballdates.Checked = false;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
            DataTable dt = cboxClass.DataSource as DataTable;
            if (dt != null && ((!rdoCUD.Checked && userRole==2)||userRole==1))
            {
                dt.Clear();
                DataRow select = dt.NewRow();
                select["Name"] = "-Select a Staff First-";
                select["ClassId"] = "0";
                dt.Rows.InsertAt(select, 0);
                cboxClass.DataSource = dt;
                cboxClass.SelectedIndex = 0;
            }
            if (rdoCUD.Checked)
            {
                btnCancel.Enabled = false;
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
            }
            

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
    
}

