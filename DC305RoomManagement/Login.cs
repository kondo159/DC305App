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

            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aspire2 Student\Documents\GitHub\DC305App\DC305RoomManagement\DC305RoomManagementDB.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * from [Users] where Email = '" + txtUser.Text + "' and Password = '" + txtPass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                Main ss = new Main();
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





