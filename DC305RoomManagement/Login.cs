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
        // Enable the drag option window when the borderstyle form is borderless 
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
        //create connection
        //verify login user details using email and password
        //identify the user information
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
                    Main ss = new Main(uemail, urole, uid);
                    ss.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect Email or Password", "Login", MessageBoxButtons.OK);
                    txtPass.Text = "";
                }
                
            }
        }
        //email validation, email cannot be entered as non-email format (ex. @.*/ signs)
        //textbox validation when nothing is entered to the textboxes, users are not allowed to continue
        private bool EmailValidation()
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtUser.Text))
                {
                    errorProvider1.SetError(txtUser,"Please provide a valid Email");
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
        //the X image on the login page to allow the user to exit the login form
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //the minimize picture on the login page that allows user to minimize the current window
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //allow user to drag the specific panel on the form
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //font color of the text when mouse hover and mouse leave
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }
    }
}





