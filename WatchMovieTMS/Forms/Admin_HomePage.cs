using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        ErrorProvider errorProviderCustom;
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
            //con.Open();
            //SqlCommand cmd = new SqlCommand("sp_addUsers", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtA_Username.Text;
            //cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtA_Password.Text;
            //cmd.Parameters.Add("@userType", SqlDbType.Int).Value = cmb_UserType.SelectedItem;
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("User Added");
            //con.Close();
            //txtA_Username.Text = "";
            //txtA_Password.Text = "";
        }
    }
}
