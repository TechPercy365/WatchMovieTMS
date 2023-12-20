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

        public void Transaction(double cost, int movie)
        {

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
