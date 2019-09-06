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
    public partial class ChangePassword : Form
    {
        string email;
        public ChangePassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
                if (PasswordValidate())
                {
                string newPassword = txt_NewPass.Text;
                string confirmPassword = txtConfirm.Text;
                if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(newPassword) && newPassword.Equals(confirmPassword))
                {
                    //do change password.
                    Connection conn = new Connection();
                    string sqlquery = "UPDATE [Users] SET Password=@newpass where Email=@Email AND Password=@password";

                    SqlCommand cmd = new SqlCommand(sqlquery, conn.OpenConn());
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@password", txtCurrent.Text);
                    cmd.Parameters.AddWithValue("@newpass", txt_NewPass.Text);


                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Password Successfully Changed", "Password Changed", MessageBoxButtons.OK);
                       
                        txtCurrent.Text = "";
                        txt_NewPass.Text = "";
                        txtConfirm.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "Please try again", MessageBoxButtons.OK);
                        errorProvider1.SetError(txtCurrent, "Current Password is Incorrect");
                        conn.CloseConn();
                    }

                }
                else
                {
                    //show the error.
                    MessageBox.Show("New Password Doesn't Match", "Please try again", MessageBoxButtons.OK);
                    errorProvider1.SetError(txtConfirm, "New Password Doesn't Match");
                }
            }
                



        }
        private bool PasswordValidate()
        {
            bool validated = true;           

            if (string.IsNullOrWhiteSpace(txtCurrent.Text))
            {
                errorProvider1.SetError(txtCurrent, "Please enter your current password");
                validated = false;
            }
            else
                errorProvider1.SetError(txtCurrent, "");
            if (string.IsNullOrWhiteSpace(txt_NewPass.Text))
            {
                errorProvider1.SetError(txt_NewPass, "Please enter new password");
                validated = false;
            }
            else
                errorProvider1.SetError(txt_NewPass, "");
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                errorProvider1.SetError(txtConfirm, "Please confirm your new password");
                validated = false;
            }
            else
                errorProvider1.SetError(txtConfirm, "");

            return validated;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
    }
}
                

               
           
              

            
                
            
