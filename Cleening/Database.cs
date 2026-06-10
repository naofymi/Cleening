using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

public static class Database
{
    private static string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    public static void Initialize()
    {
        try
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка подключения к датебазе: {ex.Message}");
        }
    }

    public static void AddRequest(string fullName, string phone, string office,
        string rooms, string services, string scheduledAt, string comment)
    {
        using (var conn = new SQLiteConnection(connStr))
        {
            conn.Open();
            string sql = @"INSERT INTO CleaningRequests 
                (FullName, Phone, Office, Rooms, Services, ScheduledAt, Comment) 
                VALUES (@FullName, @Phone, @Office, @Rooms, @Services, @ScheduledAt, @Comment)";

            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Office", office);
                cmd.Parameters.AddWithValue("@Rooms", rooms);
                cmd.Parameters.AddWithValue("@Services", services);
                cmd.Parameters.AddWithValue("@ScheduledAt", scheduledAt);
                cmd.Parameters.AddWithValue("@Comment", comment);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static List<CleaningRequest> GetAllRequests()
    {
        var requests = new List<CleaningRequest>();
        using (var conn = new SQLiteConnection(connStr))
        {
            conn.Open();
            string sql = "SELECT * FROM CleaningRequests";
            using (var cmd = new SQLiteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    requests.Add(new CleaningRequest
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Phone = reader.GetString(2),
                        Office = reader.GetString(3),
                        Rooms = reader.GetString(4),
                        Services = reader.GetString(5),
                        ScheduledAt = reader.GetString(6),
                        Comment = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        Status = reader.GetString(8),
                        Rating = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                        Feedback = reader.IsDBNull(10) ? "" : reader.GetString(10)
                    });
                }
            }
        }
        return requests;
    }

    public static void UpdateStatus(int id, string status)
    {
        using (var conn = new SQLiteConnection(connStr))
        {
            conn.Open();
            string sql = "UPDATE CleaningRequests SET Status = @Status WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static void UpdateRating(int id, int rating, string feedback)
    {
        using (var conn = new SQLiteConnection(connStr))
        {
            conn.Open();
            string sql = "UPDATE CleaningRequests SET Rating = @Rating, Feedback = @Feedback WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Rating", rating);
                cmd.Parameters.AddWithValue("@Feedback", feedback);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

public class CleaningRequest
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Office { get; set; }
    public string Rooms { get; set; }
    public string Services { get; set; }
    public string ScheduledAt { get; set; }
    public string Comment { get; set; }
    public string Status { get; set; }
    public int Rating { get; set; }
    public string Feedback { get; set; }
}