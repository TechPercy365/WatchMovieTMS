using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchMovieTMS.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
            new BookingMoviePage().Show();
            this.Hide();
        }

        private void btn_bookHistory_Click(object sender, EventArgs e)
        {
            new BookHistory().Show();
            this.Hide();
        }
    }
}
