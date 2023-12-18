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
using System.Data.Entity;

namespace WatchMovieTMS.Forms
{
    public partial class BookHistory : Form
    {
        private movieTicketManagementEntities db;
        public BookHistory()
        {
            InitializeComponent();
        }

        private void dgv_BookHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookHistory_Load(object sender, EventArgs e)
        {
            using (db = new movieTicketManagementEntities())
            {
                db.vw_BookHistory_User.ToList();
                dgv_BookHistory.DataSource = db.vw_BookHistory_User.Local.ToBindingList();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            this.Hide();
        }

        private void txt_SearchHistory_TextChanged(object sender, EventArgs e)
        {
            searchHistory();
        }
        private void searchHistory()
        {
            string searchTerm = txt_SearchHistory.Text.Trim();

            using (db = new movieTicketManagementEntities())
            {
                // Use LINQ to query the database based on the search term
                var searchResults = db.vw_BookHistory_User
                    .Where(m => m.Movie.Contains(searchTerm))
                    .ToList();

                // Display the results in the DataGridView
                dgv_BookHistory.DataSource = searchResults;
            }
        }
    }
}
