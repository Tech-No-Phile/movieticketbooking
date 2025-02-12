using MySql.Data.MySqlClient;
using System;
using System.Data;

public class dbHelper
{
    private static readonly string ConnectionString = "server=localhost;user=root;database=MovieBookingDB;port=3306;password=#@rsH@05;";

    public static DataTable GetMovies()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "SELECT Title FROM Movies"; // Ensure correct column names!

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable moviesTable = new DataTable();
                    adapter.Fill(moviesTable);
                    return moviesTable;
                }
            }
        }
    }


    public static bool BookTicket(string movieId, string seat, string customerName)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "INSERT INTO Tickets (MovieID, SeatNumber, CustomerName) VALUES (@movieId, @seat, @customerName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@movieId", movieId);
                command.Parameters.AddWithValue("@seat", seat);
                command.Parameters.AddWithValue("@customerName", customerName);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
