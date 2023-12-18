using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WatchMovieTMS.AppData;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WatchMovieTMS.Forms
{
    public partial class BookingMoviePage : Form
    {
        private movieTicketManagementEntities db = new movieTicketManagementEntities();
        public BookingMoviePage()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            this.Hide();
        }

        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btn_priceAve_Click(object sender, EventArgs e)
        {
            //int movie = 1;
            //double cost = 99.00;           
            //Transaction(cost, movie);

        }        

        private void btn_priceJohn_Click(object sender, EventArgs e)
        {
            //int movie = 2;
            //double cost = 95.00;
            //Transaction(cost, movie);
        }

        private void btn_priceJum_Click(object sender, EventArgs e)
        {
            //int movie = 3;
            //double cost = 70.00;
            //Transaction(cost, movie);
        }

        private void btn_priceSaw_Click(object sender, EventArgs e)
        {
            //int movie = 4;
            //double cost = 70.00;
            //Transaction(cost, movie);
        }

        private void btn_priceRampage_Click(object sender, EventArgs e)
        {
            //int movie = 5;
            //double cost = 85.00;
            //Transaction(cost, movie);
        }

        public void Transaction(double cost, int movie)
        {

            //int quantity = Convert.ToInt32(txt_Quantity);
            //double payment = cost * quantity;
            //txt_Payment.Text = payment.ToString();
            //int movieInfo = movie;
        }

        private void BookMovie(int userInfoID, int movieId, int quantity, int amount, int totalPayment, int totalChange)
        {
            try
            {
                string connectionString = db.Database.Connection.ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("InsertBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the stored procedure
                        command.Parameters.AddWithValue("@UserInfoID", userInfoID);
                        command.Parameters.AddWithValue("@MovieId", movieId);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@TotalPayment", totalPayment);
                        command.Parameters.AddWithValue("@TotalChange", totalChange);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Movie booked successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
