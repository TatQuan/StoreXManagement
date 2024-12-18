using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmDashboard : Form
    {
        SqlConnection connection;
        //store user name and permisstion to access here
        private User loggedInEmp;

        public frmDashboard()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
        }

        //Move form when click in top pnlControl
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pntControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Expand pnlSlidebar
        bool sidebarExpand = true;
        private void timeSlidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSlidebar.Width += 10;
                if (pnlSlidebar.Width >= 213)
                {
                    sidebarExpand = false;
                    timeSlidebar.Stop();
                }
            }
            else
            {
                pnlSlidebar.Width -= 10;
                if (pnlSlidebar.Width <= 64)
                {
                    sidebarExpand = true;
                    timeSlidebar.Stop();
                }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //??????
        }

        //Close App
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lblLogin.Location = new Point((pnlLogin.Width - lblLogin.Width) / 2, 6);
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                //Change image to reduce button decrease screen size shrink when click maximize
                btnMaximize.Image = StoreXManagement.Properties.Resources.minimize_keep_down_reduce_button_decrease_screen_size_shrink_lightColor;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //Change image to maximize when click button reduce button decrease screen size shrink
                btnMaximize.Image = StoreXManagement.Properties.Resources.maximize_lightColor;
            }
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Minimize window to taskbar
            this.WindowState = FormWindowState.Minimized;
        }

        // Centralized slide panel logic
        private void MoveSlidePanel(Button btn)
        {
            pnlSlide.Height = btn.Height;
            pnlSlide.Top = btn.Top;
        }

        //To oppen form into pnlDesktop
        private Form openForm;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            //Query check username and password
            string query = "SELECT * FROM Employee WHERE Username = @user AND Password = @Pass";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = username;
            cmd.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //Get information about user
                int empID = Convert.ToInt32(reader["EmployeeID"].ToString());
                string empName = reader["EmployeeName"].ToString();
                string access = reader["Position"].ToString();
                string userName = reader["Username"].ToString();
                loggedInEmp = new User(empID, empName, access, userName);

                MessageBox.Show("Login Successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblUser.Text = userName;
                pnlLogin.Visible = false;
                pnlHome.Visible = true;
                lblWelcome.Text = "Welcome " + username;
                lblWelcome.Location = new Point((pnlHome.Width - lblWelcome.Width)/2, (pnlHome.Height - lblWelcome.Height)/2);
            }
            else
            {
                lblNotificate.Text = "Wrong user or password";
            }
            connection.Close();
        }

        private void OpenForm(Form childForm, object btnOpen)
        {
            if (openForm != null)
                openForm.Close();
                openForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.pnlDesktop.Controls.Add(childForm);
                this.pnlDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Move light panle to button when click
            MoveSlidePanel(btnHome);
            if (openForm == null)
            {
                return;
            }
            openForm.Close();
           
        }

        private void CheckNull()
        {
            if (loggedInEmp == null)
            {
                loggedInEmp = new User();
                loggedInEmp.Access = string.Empty;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CheckNull();
            MoveSlidePanel(btnCustomer);
            OpenForm(new frmCustomerManagement(loggedInEmp.Access), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            CheckNull();
            MoveSlidePanel(btnEmployee);
            OpenForm(new frmEmployeeManagement(loggedInEmp.Access), sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            CheckNull();
            MoveSlidePanel(btnProduct);
            OpenForm(new frmProductManagement(loggedInEmp), sender);
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            CheckNull();
            MoveSlidePanel(btnInvoice);
            OpenForm(new frmInvoice(loggedInEmp), sender);
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            timeSlidebar.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInEmp.EmpID = 0;
            loggedInEmp.EmpName = string.Empty;
            loggedInEmp.UserName = string.Empty;
            loggedInEmp.Access = string.Empty;
            lblUser.Text = "";
            btnHome_Click(sender, e);
            btnCancel_Click(sender, e);
            pnlLogin.Visible = true;
            pnlHome.Visible = false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            lblNotificate.Text = string.Empty;
        }

        private void picHideShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar != true)
            {
                picHideShow.Image = StoreXManagement.Properties.Resources.show_darkColor;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                picHideShow.Image = StoreXManagement.Properties.Resources.hide_darkColor;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CheckNull();
            MoveSlidePanel(btnReport);
            OpenForm(new frmReport(loggedInEmp), sender);
        }
    }
}
