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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select * from [Users] where Email = '" + txtUser.Text + "' and Password = '" + txtPass.Text + "'", con.OpenConn());
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dtbl = new DataTable();
            

            if (reader.HasRows)
            {
                
                string uemail="";
                int urole=0;
               while (reader.Read())
                {
                    uemail= reader.GetString(4);
                    urole= reader.GetInt32(6);
                       

                }
               this.Hide();
               Main ss = new Main(uemail, urole);
               ss.Show();
               
                
            }
                
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Login",MessageBoxButtons.OK);
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
    }
}





