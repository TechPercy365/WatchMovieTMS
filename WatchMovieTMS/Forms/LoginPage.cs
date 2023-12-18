using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchMovieTMS.AppData;
using WatchMovieTMS.Forms;

namespace WatchMovieTMS
{
    public partial class LoginPage : Form
    {
        UserRepository userRepo;
        ErrorProvider errorProviderCustom;
        public LoginPage()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtb_Username.Text))
            {
                errorProviderCustom.SetError(txtb_Username, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtb_Password.Text))
            {
                errorProviderCustom.SetError(txtb_Password, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtb_Username.Text);

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtb_Password.Text))
                {
                    // Assigned to a singleton
                    UserLogged.GetInstance().User = userLogged;

                    switch ((Role)userLogged.userType)
                    {
                        case Role.Customer:
                            // Load student Dashboard
                            new HomePage().Show();
                            this.Hide();
                            break;
                        case Role.Admin:
                            // Load Teacher Dashboard
                            new Admin_HomePage().Show();
                            this.Hide();
                            break;                        
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void btn_RegAcc_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
