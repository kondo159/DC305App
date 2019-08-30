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
    public partial class UserManager : Form
    {
        
        SqlCommand cmd;
         
        string connStr = ConfigurationManager.ConnectionStrings["DC305RoomManagementDB"].ConnectionString;
        DataTable dt;
        SqlDataAdapter sqlda;
        
        
       
        
        public UserManager()
        {
            InitializeComponent();
        }
        string Gender;
        public void ClearForm()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            dtDOB.Text = "";
            cboRole.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtID.Text = "";

        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
           
            try
            {
                string value = "Male";
                bool isChecked = rbtnMale.Checked;
                if (isChecked)
                    value = rbtnMale.Text;
                else
                    value = rbtnFemale.Text;

                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("INSERT INTO [Users] (Name, DOB, Gender, Email, Password, Role) VALUES (@Name, @DOB, @Gender, @Email, @Password, @Role)", conn);

                cmd.Parameters.AddWithValue("@Name", this.txtName.Text);
                cmd.Parameters.AddWithValue("@DOB", this.dtDOB.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", this.txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", this.cboRole.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Success");
                LoadData();
                ClearForm();
               
                
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                
            }
        }

        private void RbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void RbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void RbtnMale_Validating(object sender, CancelEventArgs e)
        {

        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            this.dtgGrid.DefaultCellStyle.Font = new Font("Proxima Nova", 8.5F);
            dtgGrid.BorderStyle = BorderStyle.None;
            dtgGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgGrid.BackgroundColor = Color.White;

            dtgGrid.EnableHeadersVisualStyles = false;
            dtgGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtgGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Proxima Nova", 9.5F, FontStyle.Bold);
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {

                DataTable dt = new DataTable();
                cmd = new SqlCommand("select * from Users", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dtgGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data to Show");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE [Users] SET Name = @Name, DOB = @DOB, Gender = @Gender, " +
                    "Email = @Email, Password = @Password, Role = @Role WHERE UserId = '" + txtID.Text + "'", conn);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@DOB", dtDOB.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", cboRole.Text);
                conn.Open();

               if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Update Successfully.", "Status", MessageBoxButtons.OK);
                        LoadData();
                    }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                
                ClearForm();
            }

        }

               private void BtnSearch_Click(object sender, EventArgs e)
        {
           

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchUserEmail(txtSearch.Text);
           
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }
        public void SearchUserEmail(string search)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = "select * from [Users] where [Email]+' '+[Name] like '%" + search + "%'";
            sqlda = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            sqlda.Fill(dt);
            dtgGrid.DataSource = dt;
            conn.Close();
        }
        private void LblDOB_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DtgGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                ClearForm();
                DataGridViewRow row = dtgGrid.Rows[e.RowIndex];
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                dtDOB.Text = row.Cells["DOB"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cboRole.Text = row.Cells["Role"].Value.ToString();
                txtID.Text = row.Cells["UserId"].Value.ToString();
                if (row.Cells["Gender"].Value.ToString().Trim().Equals("Female"))
                {
                    rbtnFemale.Checked = true;
                }
                else
                {
                    rbtnMale.Checked = true;
                }
            }
            
        }

        private void CboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
