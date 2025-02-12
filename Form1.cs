using System;
using System.Data;
using System.Windows.Forms;

namespace movieticketbooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                // Fetch movies from dbHelper (Updated)
                DataTable movies = dbHelper.GetMovies();

                if (movies.Rows.Count > 0)
                {
                    ComboBoxMovies.DataSource = movies;
                    ComboBoxMovies.DisplayMember = "MovieName"; // Column name from DB
                    ComboBoxMovies.ValueMember = "MovieID"; // Column name from DB
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movies: " + ex.Message);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (ComboBoxMovies.SelectedValue == null || listBoxSeats.SelectedItem == null || txtCustomerName.Text == "")
            {
                MessageBox.Show("Please select a movie, seat, and enter your name.");
                return;
            }

            string movieId = ComboBoxMovies.SelectedValue.ToString();
            string seat = listBoxSeats.SelectedItem.ToString();
            string customerName = txtCustomerName.Text;

            try
            {
                bool isBooked = dbHelper.BookTicket(movieId, seat, customerName);

                if (isBooked)
                {
                    lblConfirmation.Text = "Ticket Booked Successfully!";
                    MessageBox.Show("Ticket booked successfully for " + customerName);
                }
                else
                {
                    MessageBox.Show("Error booking ticket.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking error: " + ex.Message);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (lblConfirmation.Text == "")
            {
                MessageBox.Show("Please book a ticket first.");
                return;
            }

            string ticketDetails = $"Movie: {ComboBoxMovies.Text}\n" +
                                   $"Seat: {listBoxSeats.SelectedItem}\n" +
                                   $"Customer: {txtCustomerName.Text}\n" +
                                   $"Date: {DateTime.Now}";

            MessageBox.Show("Printing Ticket:\n\n" + ticketDetails);
        }
    }
}
