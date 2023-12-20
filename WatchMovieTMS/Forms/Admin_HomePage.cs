using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchMovieTMS.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WatchMovieTMS.Forms
{
    public partial class Admin_HomePage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=movieTicketManagement; Integrated Security=true");
        UserRepository userRepo;
        int? userSelectedId = null;

        private movieTicketManagementEntities db;
        public Admin_HomePage()
        {
            InitializeComponent();
        }

        private void Admin_HomePage_Load(object sender, EventArgs e)
        {
        }        
        
        private void btn_Signout_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();

        }
        private void btn_viewUsers_Click(object sender, EventArgs e)
        {
            AllUserRole();
        }
        public void AllUserRole()
        {
            using (db = new movieTicketManagementEntities())
            {
                db.vw_Users.ToList();
                dgv_showInfo.DataSource = db.vw_Users.Local.ToBindingList();
            }
        }

        private void btn_Movies_Click(object sender, EventArgs e)
        {
            using (db = new movieTicketManagementEntities())
            { 
                db.Movies.Load();

                dgv_showInfo.DataSource = db.Movies.Local.ToBindingList();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //String username = txtA_Username.Text;
            //String pass = txtA_Password.Text;

            //String strOutputMsg = "";
            //// Validation not allow empty or null value
            //if (String.IsNullOrEmpty(username))
            //{
            //    MessageBox.Show("Empty Field. Please Fill up");
            //    return;
            //}
            //else
            //// Validation not allow empty or null value
            //if (String.IsNullOrEmpty(pass))
            //{
            //    MessageBox.Show("Empty Field. Please Fill up");
            //    return;
            //}                       

            ////Create new object of USER_ACCOUNT
            //User newUserAcc = new User();
            //newUserAcc.userName = txtA_Username.Text;
            //newUserAcc.password = txtA_Password.Text;            

            //ErrorCode retValue = userRepo.NewUser(newUserAcc, ref strOutputMsg);
            //if (retValue == ErrorCode.Success)
            //{                                
            //    txtA_Username.Clear();
            //    txtA_Password.Clear();
            //}
            //else
            //{
            //    // error 
            //    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

    }
}
