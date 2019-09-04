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
using System.Text.RegularExpressions;

namespace DC305RoomManagement
{
    public partial class UserManager : Form
    {
        
        SqlCommand cmd;

        Connection conn = new Connection();
        DataTable dt;
        SqlDataAdapter sqlda;
        
        
       
        
        public UserManager()
        {
            InitializeComponent();
            Load_cbRole();
        }
        string Gender;
        string oldEmail; 


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
            
            if (ValidateAll())
            {
                try
                {
                    string value = "Male";
                    bool isChecked = rbtnMale.Checked;
                    if (isChecked)
                        value = rbtnMale.Text;
                    else
                        value = rbtnFemale.Text;


                    SqlCommand cmd = new SqlCommand("INSERT INTO [Users] (Name, DOB, Gender, Email, Password, Role) VALUES (@Name, @DOB, @Gender, @Email, @Password, @Role)", conn.OpenConn());

                    cmd.Parameters.AddWithValue("@Name", this.txtName.Text);
                    cmd.Parameters.AddWithValue("@DOB", this.dtDOB.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", this.txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", Convert.ToInt32(this.cboRole.SelectedValue));


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success");



                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.CloseConn();
                    LoadData();
                    ClearForm();
                }

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
            dtgGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11.75F);
            LoadData();
            txtID.Hide();
        }
        private void LoadData()
        {
          
            try
            {

                DataTable dt = new DataTable();
                cmd = new SqlCommand("select Users.*, Roles.Name as RoleName from Users LEFT JOIN Roles ON Users.Role = Roles.RoleId",  conn.OpenConn());
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
                conn.CloseConn();
            }
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ClearForm();
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if(ValidateAll())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("UPDATE [Users] SET Name = @Name, DOB = @DOB, Gender = @Gender, " +
                        "Email = @Email, Password = @Password, Role = @Role, Active=@Active WHERE UserId = '" + txtID.Text + "'", conn.OpenConn());


                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@DOB", dtDOB.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", Convert.ToInt32(cboRole.SelectedValue));
                    cmd.Parameters.AddWithValue("@Active", btnDisable.Text == "Disable" ? true : false);



                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Update Successfully.", "Status", MessageBoxButtons.OK);

                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.CloseConn();
                    LoadData();
                    ClearForm();
                }
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
          
          
            string query = "SELECT Users.*, Roles.Name as RoleName FROM Users LEFT JOIN Roles ON Users.Role = Roles.RoleId where [Email]+' '+Users.Name like '%" + search + "%'";
            sqlda = new SqlDataAdapter(query, conn.OpenConn());
            dt = new DataTable();
            sqlda.Fill(dt);
            dtgGrid.DataSource = dt;
            conn.CloseConn();
        }
        private void LblDOB_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DtgGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                ClearForm();
                DataGridViewRow row = dtgGrid.Rows[e.RowIndex];
                
                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
                oldEmail = row.Cells["Email"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtName.Text = row.Cells["NameC"].Value.ToString();
                dtDOB.Text = row.Cells["DOB"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cboRole.Text = row.Cells["Role"].Value.ToString();
                txtID.Text = row.Cells["UserId"].Value.ToString();
                if (row.Cells["Genders"].Value.ToString().Trim().Equals("Female"))
                {
                    rbtnFemale.Checked = true;
                }
                else
                {
                    rbtnMale.Checked = true;
                }
                if (row.Cells["Active"].Value.ToString() == true.ToString())
                    btnDisable.Text = "Disable";
                else
                    btnDisable.Text = "Enable";
            }
            
        }

        private void CboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Load_cbRole()
        {
            SqlCommand cmd = new SqlCommand("Select * from Roles", conn.OpenConn());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "RoleId";
            cboRole.DataSource = dt;
            conn.CloseConn();
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            if (btnDisable.Text == "Enable")
            btnDisable.Text = "Disable";
            else
            btnDisable.Text = "Enable";

        }
        private bool ValidateAll()
        {
            bool validated = true;
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text))
                {
                    errorProvider.SetError(txtEmail, "Please provide valid Email");
                    validated = false;
                }
                errorProvider.SetError(txtEmail, "");
              
            }
            else
            {
                errorProvider.SetError(txtEmail, "Please insert Email");
                validated = false;
            }

            if (!(rbtnFemale.Checked || rbtnMale.Checked))
            {
                errorProvider.SetError(grpGender, "Select Gender");
                validated = false;
            }
            else
            {
                errorProvider.SetError(grpGender, "");
             
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                errorProvider.SetError(txtName, "Please enter name");
                validated = false;
            }
            else
                errorProvider.SetError(txtName, "");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Please enter password");
                validated = false;
            }
            else
                errorProvider.SetError(txtPassword, "");
               
            string filter = "Email= '" + txtEmail.Text + "'";
            int userEmail = (dtgGrid.DataSource as DataTable).Select(filter).Length;
            if (!(txtEmail.Text == oldEmail))  
                if (userEmail > 0)
                {
                
                MessageBox.Show("Email already exist, please choost another", "Notification", MessageBoxButtons.OK);
                errorProvider.SetError(txtEmail, "Email already exist");
                validated = false;
                }
              
            

            
            return validated;
        }

        

        private void BtnDisable_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.White;           
        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.Black;
        }

        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.White;
        }
        private void BtnUpdate_MouseLeave_1(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = SystemColors.ControlText;
        }
        private void BtnReset_MouseEnter_1(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.White;
        }

        private void BtnReset_MouseLeave_1(object sender, EventArgs e)
        {
            btnReset.ForeColor = SystemColors.ControlText;
        }

        private void BtnDisable_MouseEnter(object sender, EventArgs e)
        {
            btnDisable.ForeColor = Color.White;
        }
private void BtnDisable_MouseLeave(object sender, EventArgs e)
        {
            btnDisable.ForeColor = SystemColors.ControlText;
        }

        private void DtgGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
