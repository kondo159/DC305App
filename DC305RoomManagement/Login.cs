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
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (EmailValidation()&& PasswordValidation())
            {
                Connection con = new Connection();
                SqlCommand cmd = new SqlCommand("Select * from [Users] where Email = '" + txtUser.Text + "' and Password = '" + txtPass.Text + "'", con.OpenConn());
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtbl = new DataTable();

            if (reader.HasRows)
                {

                    string uemail = "";
                    int urole = 0;
                    int uid = 0;
                    while (reader.Read())
                    {
                        uemail = reader.GetString(4);
                        urole = reader.GetInt32(6);
                        uid= reader.GetInt32(0);


                    }
                    this.Hide();
                    Main ss = new Main(uemail, urole,uid);
                    ss.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Login", MessageBoxButtons.OK);
                    txtPass.Text = "";
                }
            }
        }
        private bool EmailValidation()
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtUser.Text))
                {
                    errorProvider1.SetError(txtUser,"Please provide valid Email");
                    return false;
                }
                errorProvider1.SetError(txtUser, "");
                return true;
            }
            errorProvider1.SetError(txtUser, "Please insert Email");
            return false;
        }
        private bool PasswordValidation()
        {
            if (!string.IsNullOrWhiteSpace(txtPass.Text))
            {               
                errorProvider1.SetError(txtPass, "");
                return true;
            }
            errorProvider1.SetError(txtPass, "Please insert your password");
            return false;
        }
        private void Login_Load(object sender, EventArgs e)
        {
          // lbl_header.Font = new Font(lbl_header.Font.Name, 28, FontStyle.Bold);
        }
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}





