using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private readonly string connectionString = "server=your_server;user=your_user;database=MovieBookingDB;port=3306;password=your_password;";

    // Load Movies
    public List<string> GetMovies()
    {
        List<string> movies = new List<string>();
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT MovieName FROM Movies";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(reader.GetString("MovieName"));
                    }
                }
            }
        }
        return movies;
    }

    // Load Available Seats
    public List<string> GetAvailableSeats(string movieName)
    {
        List<string> seats = new List<string>();
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = @"SELECT SeatNumber FROM Seats 
                             WHERE MovieID = (SELECT MovieID FROM Movies WHERE MovieName = @MovieName) 
                             AND IsBooked = FALSE";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        seats.Add(reader.GetString("SeatNumber"));
                    }
                }
            }
        }
        return seats;
    }

    // Book a Seat
    public bool BookSeat(string customerName, string movieName, string seatNumber)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            // Get MovieID
            string getMovieIdQuery = "SELECT MovieID FROM Movies WHERE MovieName = @MovieName";
            int movieId;
            using (MySqlCommand cmd = new MySqlCommand(getMovieIdQuery, conn))
            {
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                movieId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Get SeatID
            string getSeatIdQuery = "SELECT SeatID FROM Seats WHERE SeatNumber = @SeatNumber AND MovieID = @MovieID";
            int seatId;
            using (MySqlCommand cmd = new MySqlCommand(getSeatIdQuery, conn))
            {
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                cmd.Parameters.AddWithValue("@MovieID", movieId);
                seatId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Insert Booking
            string insertBookingQuery = "INSERT INTO Bookings (CustomerName, MovieID, SeatID) VALUES (@CustomerName, @MovieID, @SeatID)";
            using (MySqlCommand cmd = new MySqlCommand(insertBookingQuery, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@MovieID", movieId);
                cmd.Parameters.AddWithValue("@SeatID", seatId);
                cmd.ExecuteNonQuery();
            }

            // Update Seat Status
            string updateSeatQuery = "UPDATE Seats SET IsBooked = TRUE WHERE SeatID = @SeatID";
            using (MySqlCommand cmd = new MySqlCommand(updateSeatQuery, conn))
            {
                cmd.Parameters.AddWithValue("@SeatID", seatId);
                cmd.ExecuteNonQuery();
            }

            return true;
        }
    }
}
