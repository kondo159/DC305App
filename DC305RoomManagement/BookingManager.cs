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
using System.Drawing.Printing;
using DC305RoomManagementClassLibrary;

namespace DC305RoomManagement
{
    public partial class BookingManager : Form
    {
        private Connection conn = new Connection();
        private int userId = 0;//Id of the log in User
        private int userRole = 0;//1=admin 2= staff 3=student
        private int activedBooking = 0; //id of the booking that is beening edited
        private string bRoom;
        private string bClass;
        private string sTime;
        private string eTime;

        public BookingManager(int user,int role)
        {
            InitializeComponent();
            userId = user;
            userRole = role;
        }
        /// <summary>
        /// Method to setup the form and datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookingManager_Load(object sender, EventArgs e)
        {
            dgvBookingList.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgvBookingList.AutoGenerateColumns = false;
            LoadComboBox("Select * from Rooms where Enable=1", "RoomId", cboxRoom);
            if (userRole == 3)
            {
                btnCancel.Visible = false;
                btnCreate.Visible = false;
                btnUpdate.Visible = false;
                cballdates.Visible = true;
                rdoCUD.Visible = false;
                rdoFilter.Visible = false;
                btnFilter.Enabled = true;
                LoadComboBox("Select * from Users where Role=2", "UserId", cboxStaff);
                LoadComboBox("Select Class.ClassId,Class.Name from Class" +
                        " left join[Group]  on Class.GroupOfStudents =[Group].GroupId" +
                        " left join GroupOfStudents gs on [Group].GroupId = gs.GroupId" +
                        " where Class.Active=1 and gs.Student=" + userId, "ClassId", cboxClass); ;
            }
            else
            {
                LoadComboBox("Select * from Users where Role=2", "UserId", cboxStaff);
                LoadComboBox("Select ClassId,Name from Class", "ClassId", cboxClass);
            }
            
            ResetForm();
                                        
                
            
            if (userRole == 2)                           
                SetStaffCUDMenu();
            else
                cboxStaff.SelectedValueChanged += new EventHandler(CboxStaff_SelectedIndexChanged);




        }
        /// <summary>
        /// Method to populate the datagridview 
        /// </summary>
        private void LoadBookingList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd;
            try
            {
                if(userRole!=3)
                    cmd = new SqlCommand("Select Bookings.*,Class.Name as ClassName,Class.Teacher,t.Name as teacherName,Rooms.Name as RoomName,Users.Name as UserName from Bookings Left join Class on Class.ClassId=Bookings.ClassId left join Rooms on Rooms.RoomId=Bookings.RoomId left join users on Users.UserId=Bookings.UserId left join users t on T.UserId=Class.Teacher", conn.OpenConn());
                else
                {
                    cmd = new SqlCommand("Select Bookings.*,Class.Name as ClassName,Class.Teacher,t.Name as teacherName,Rooms.Name as RoomName,Users.Name as UserName from Bookings" +
                        " Left join Class on Class.ClassId = Bookings.ClassId" +
                        " Left join Rooms on Rooms.RoomId = Bookings.RoomId" +
                        " left join users on Users.UserId = Bookings.UserId" +
                        " left join users t on T.UserId = Class.Teacher" +
                        " left join [Group]  on Class.GroupOfStudents = [Group].GroupId" +
                        " left join GroupOfStudents gs on [Group].GroupId = gs.GroupId where gs.Student = @id", conn.OpenConn());
                    cmd.Parameters.AddWithValue("@id", userId);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dt.DefaultView.RowFilter = "EDateTime>=#"+ DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "#";
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
            catch(Exception)
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
            string staffId = cboxStaff.SelectedValue.ToString();
            string sqlCommand = "";
            if (cboxStaff.SelectedValue.ToString() != "0") { 
                if(userRole != 3)                          
                    sqlCommand = "Select ClassId,Name from Class where Teacher=" + staffId + " and Active=1";                
                else
                {
                    sqlCommand = "Select Class.ClassId,Class.Name from Class" +
                        " left join[Group]  on Class.GroupOfStudents =[Group].GroupId" +
                        " left join GroupOfStudents gs on [Group].GroupId = gs.GroupId" +
                        " where Class.Teacher=" + staffId + " and Class.Active=1 and gs.Student=" + userId;
                }
                LoadComboBox(sqlCommand, "ClassId", cboxClass);
            }
            else
                if(userRole == 3)
                {
                    sqlCommand = "Select Class.ClassId,Class.Name from Class" +
                           " left join[Group]  on Class.GroupOfStudents =[Group].GroupId" +
                           " left join GroupOfStudents gs on [Group].GroupId = gs.GroupId" +
                           " where Class.Active=1 and gs.Student=" + userId;
                    LoadComboBox(sqlCommand, "ClassId", cboxClass);
                }
                    
            
        }               
        /// <summary>
        /// method to change the active buttons when filter option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// method to change the active buttons when CUD option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// method for the CUD menu when Staff is logged in
        /// </summary>
        private void SetStaffCUDMenu()
        {
            ResetForm();
            cboxStaff.SelectedValue = userId;            
            cboxStaff.Enabled = false;
            string sqlCommand = "Select ClassId,Name from Class where Teacher=" + userId + " and Active=1";
            LoadComboBox(sqlCommand, "ClassId", cboxClass);
            
        }
        /// <summary>
        /// method to filter the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFilter_Click(object sender, EventArgs e)
        {            
            string filter = "1=1";
            if (!cballdates.Checked)
            {
                filter += string.Format("AND SDateTime > '{0}' and SDateTime < '{1}'", dtpStart.Value, dtpEnd.Value);
                filter += string.Format("AND EDateTime > '{0}' and EDateTime < '{1}'", dtpStart.Value, dtpEnd.Value);
            }
                
            if (cboxRoom.SelectedValue.ToString() != "0")
                filter += " AND RoomId= " + cboxRoom.SelectedValue.ToString();
            if(cboxClass.SelectedValue.ToString()!= "0")
                filter += " AND ClassId= " + cboxClass.SelectedValue.ToString();
            if(cboxStaff.SelectedValue.ToString()!="0")
                filter += " AND Teacher= " + cboxStaff.SelectedValue.ToString();
            (dgvBookingList.DataSource as DataTable).DefaultView.RowFilter = filter;
            
        }
        /// <summary>
        /// when checkbox is checked disable both datapicker 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cballdates_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = !dtpStart.Enabled;
            dtpEnd.Enabled = !dtpEnd.Enabled;
        }
        /// <summary>
        /// method to reset the form and dataGridView
        /// </summary>
        private void ResetForm()
        {
            LoadBookingList();
            errorProvider1.Clear();
            activedBooking = 0;
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
            else
                cboxClass.SelectedIndex = 0;
            if (rdoCUD.Checked)
            {
                btnCancel.Enabled = false;
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
            }
            

        }
        /// <summary>
        /// function of the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            DataGridViewSelectionMode oldmode = dgvBookingList.SelectionMode;
            dgvBookingList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookingList.ClearSelection();
            dgvBookingList.SelectionMode = oldmode;
        }
        /// <summary>
        /// Event to bring the selected information to the form for edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBookingList.Rows[e.RowIndex];
            if (rdoCUD.Checked && (userRole==1 || (int)row.Cells["TeacherId"].Value==userId))
            {
                btnCancel.Enabled = true;
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;                
                activedBooking = (int)row.Cells["BookingId"].Value;
                dtpStart.Value = (DateTime)row.Cells["SDateTime"].Value;
                sTime = row.Cells["SDateTime"].Value.ToString();
                dtpEnd.Value = (DateTime)row.Cells["EDateTime"].Value;
                eTime = row.Cells["EDateTime"].Value.ToString();
                cboxRoom.SelectedValue = (int)row.Cells["RoomId"].Value;
                bRoom = row.Cells["RoomName"].Value.ToString();
                cboxStaff.SelectedValue = (int)row.Cells["TeacherId"].Value;
                cboxClass.SelectedValue = (int)row.Cells["ClassId"].Value;
                
                bClass = row.Cells["ClassName"].Value.ToString();
            }            
            
        }
        /// <summary>
        /// event for Create button saves the info into DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert INTO Bookings (ClassId,RoomId,UserId,SDateTime,EDateTime) values(@class,@room,@user,@Sdate,@Edate)", conn.OpenConn());
                    cmd.Parameters.AddWithValue("@class", Convert.ToInt32(cboxClass.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@room", Convert.ToInt32(cboxRoom.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@user", userId);
                    cmd.Parameters.AddWithValue("@Sdate", dtpStart.Value.ToString());
                    cmd.Parameters.AddWithValue("@Edate", dtpEnd.Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Completed", "Create Booking", MessageBoxButtons.OK);


                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.CloseConn();
                    string mailbody = "Room: " + cboxRoom.Text + "</br>"
                            + "Class: " + cboxClass.Text + "</br>"
                            + "Start Time:" + dtpStart.Value.ToString() + "</br>"
                            + "End Time:" + dtpEnd.Value.ToString();
                    SendEmail(mailbody, "New Booking Entry Created");
                    ResetForm();
                    LoadBookingList();
                }
        }
        private void SendEmail(string mailbody,string subject)
        {
            
            SqlCommand cmd = new SqlCommand("Select Users.Email from  Users" +
                                    " left join GroupOfStudents on Users.UserId=GroupOfStudents.Student" +
                                    " left join Class on Class.GroupOfStudents=GroupOfStudents.GroupId" +
                                    " where Class.ClassId=" + Convert.ToInt32(cboxClass.SelectedValue.ToString()), conn.OpenConn());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SMTPHelper.SendEmail(reader.GetString(0), mailbody, subject);
                }
                //SMTPHelper.SendEmail("captainxbehemoth@gmail.com", mailbody, "new booking created");
            }
            conn.CloseConn();
            cmd = new SqlCommand("Select Email from  Users where UserId=" + Convert.ToInt32(cboxStaff.SelectedValue.ToString()), conn.OpenConn());
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SMTPHelper.SendEmail(reader.GetString(0), mailbody, "new booking created");
                }
                //SMTPHelper.SendEmail("captainxbehemoth@gmail.com", mailbody, "new booking created");
            }
            conn.CloseConn();
        }
        /// <summary>
        /// Event in Update Button to update data in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
                try
                {
                    SqlCommand cmd = new SqlCommand("Update Bookings Set ClassId=@class, RoomId=@room, UserId=@user, SDateTime=@Sdate , EDateTime=@Edate where bookingId=@id", conn.OpenConn());
                    cmd.Parameters.AddWithValue("@class", Convert.ToInt32(cboxClass.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@room", Convert.ToInt32(cboxRoom.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@user", userId);
                    cmd.Parameters.AddWithValue("@Sdate", dtpStart.Value.ToString());
                    cmd.Parameters.AddWithValue("@Edate", dtpEnd.Value.ToString());
                    cmd.Parameters.AddWithValue("@id", activedBooking);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Completed", "Update Booking", MessageBoxButtons.OK);
                }
                catch(Exception)
                {
                    throw;
                }
                finally
                {
                    conn.CloseConn();
                    string mailbody = "Updated Booking </br>"
                            + "Room: " + cboxRoom.Text + "</br>"
                            + "Class: " + cboxClass.Text + "</br>"
                            + "Start Time:" + dtpStart.Value.ToString() + "</br>"
                            + "End Time:" + dtpEnd.Value.ToString() + "</br></br>"
                            + "Previous Booking</br>"
                            + "Room: " + bRoom + "</br>"
                            + "Class: " + bClass + "</br>"
                            + "Start Time:" + sTime + "</br>"
                            + "End Time:" + eTime + "</br></br>";
         
                  
                    SendEmail(mailbody, "Booking Entry Updated");
                    ResetForm();
                    LoadBookingList();
                }
        }
        /// <summary>
        /// Event for Cancel Button to Delete Record from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel this Booking?", "Cancel Booking", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Bookings where BookingId=@booking", conn.OpenConn());
                    cmd.Parameters.AddWithValue("@booking",activedBooking);                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.CloseConn();
                    string mailbody = "Cancelled Booking </br>"
                            + "Room: " + cboxRoom.Text + "</br>"
                            + "Class: " + cboxClass.Text + "</br>"
                            + "Start Time:" + dtpStart.Value.ToString() + "</br>"
                            + "End Time:" + dtpEnd.Value.ToString();
                    SendEmail(mailbody, "Booking Entry Cancelled");
                    ResetForm();
                    LoadBookingList();
                }
            }
        }
        /// <summary>
        /// Event for print button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {

            PrintDialog printDlg = new PrintDialog();
            //PrintDocument printDoc = new PrintDocument();
            printDocument1.DocumentName = "Activities";
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            // preview the assigned document or you can create a different previewButton for it
            printPrvDlg.Document = printDocument1;
            printPrvDlg.ShowDialog();

            printDlg.Document = printDocument1;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        /// <summary>
        /// Method to construct the file that will be printed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int cHeight = dgvBookingList.Rows[0].Height;//Height of the cells
            
            int x = 100;//start position for the first collumn
            
            for (int c = 0; c < dgvBookingList.Columns.Count; c++)
            {
                int y = 100;//reset possition to the top
                if (dgvBookingList.Columns[c].Visible)
                {
                   //Draws a rectangle  
                    e.Graphics.DrawRectangle(Pens.Black, x, y,
                    dgvBookingList.Columns[c].Width, cHeight);

                    
                    //Fills the above drawn rectangle with a light gray colour just to distinguish the header 
                    e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y,
                        dgvBookingList.Columns[c].Width, cHeight));

                    //Draws a text inside the above drawn rectangle whose value is same of the first column. 

                   e.Graphics.DrawString(dgvBookingList.Columns[c].HeaderText,
                        dgvBookingList.Font, Brushes.Black, new RectangleF(x, y,
                        dgvBookingList.Columns[c].Width, cHeight));

                    for (int r = 0; r < dgvBookingList.Rows.Count; r++)
                    {
                        int rowheight = dgvBookingList.Rows[r].Height;
                        int colwidth = dgvBookingList.Columns[0].Width;
                        y += rowheight; //increment the y co-ordinate 
                        //Draws a rectangle 
                        e.Graphics.DrawRectangle(Pens.Black, x, y, colwidth, rowheight);
                        //Insert data inside the rectangle 
                        e.Graphics.DrawString(dgvBookingList.Rows[r].Cells[c].FormattedValue.ToString(),
                         dgvBookingList.Font, Brushes.Black, new RectangleF(x, y, colwidth, rowheight));
                    }
                    x += dgvBookingList.Columns[c].Width;//move to the next collumn
                }
            }                                              
        }
        /// <summary>
        /// Method to validate the fields for create and Update data
        /// </summary>
        /// <returns></returns>
        private bool FieldsValidation()
        {
            bool valid = true;
            bool free = true;
            string filter = string.Format(" ((SDateTime >= #{0}# AND SDateTime <= #{1}#)"+
                " OR(#{0}#>=SDateTime AND #{0}#<=EDateTime))"+
                " AND((EDateTime >= #{0}# AND EDateTime <= #{1}#) "+
                " OR(#{1}#>=SDateTime AND #{1}#<=EDateTime))"+
                " AND RoomId ={2} AND BookingId<>{3}",
                dtpStart.Value, dtpEnd.Value, cboxRoom.SelectedValue.ToString(),activedBooking);
            int numr = (dgvBookingList.DataSource as DataTable).Select(filter).Length;
            if(dtpStart.Value.ToString()!=sTime || dtpEnd.Value.ToString() != eTime)
            if (numr> 0)
            {
                errorProvider1.SetError(dtpStart, "Already Exist an Activity booked for this time on this room");
                errorProvider1.SetError(dtpEnd, "Already Exist an Activity booked for this time on this room");
                valid = false;
                free = false;
            }
            if (dtpStart.Value > dtpEnd.Value)
            {
                errorProvider1.SetError(dtpStart, "Start Time must be earlier than End Time");
                errorProvider1.SetError(dtpEnd, "END Time must be Later than Start Time");
                valid = false;
                free = false;
            }
            if (dtpStart.Value <= DateTime.Now)
            {
                errorProvider1.SetError(dtpStart, "Start Time need to be later than actual time");                
                valid = false;
                free = false;
            }
            if (free)
            {
                errorProvider1.SetError(dtpStart, "");
                errorProvider1.SetError(dtpEnd, "");
            }                             
            if(!ValidateCBox(cboxRoom, "A Room must be selected"))          
                valid = false;
            if(!ValidateCBox(cboxStaff, "A Staff must be selected"))
                valid = false;
            if (!ValidateCBox(cboxClass, "A Class must be selected"))
                valid = false;

            return valid;
        }
        /// <summary>
        /// general method to validate if a valid value was selected
        /// </summary>
        /// <param name="cbox"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool ValidateCBox(ComboBox cbox,string msg)
        {
            bool valid = true;
            if ((int)cbox.SelectedValue == 0)
            {
                errorProvider1.SetError(cbox, msg);
                valid = false;
            }
            else
                errorProvider1.SetError(cbox, "");
            return valid;
        }

        private void BtnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.White;
            btnCreate.BackColor = Color.ForestGreen;
        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.Black;
            btnCreate.BackColor = Color.DarkKhaki;
        }

        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.White;
            btnUpdate.BackColor = Color.ForestGreen;
        }

        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.BackColor = Color.DarkKhaki;
        }

        private void BtnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.White;
            btnReset.BackColor = Color.ForestGreen;
        }

        private void BtnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.Black;
            btnReset.BackColor = Color.DarkKhaki;
        }

        private void BtnFilter_MouseEnter(object sender, EventArgs e)
        {
            btnFilter.ForeColor = Color.White;
            btnFilter.BackColor = Color.ForestGreen;
        }

        private void BtnFilter_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.ForeColor = Color.Black;
            btnFilter.BackColor = Color.DarkKhaki;
        }

        private void BtnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.White;
            btnPrint.BackColor = Color.ForestGreen;
        }

        private void BtnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.Black;
            btnPrint.BackColor = Color.DarkKhaki;
        }

        private void BtnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.White;
            btnCancel.BackColor = Color.ForestGreen;
        }

        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
            btnCancel.BackColor = Color.DarkKhaki;
        }
    }   

}

