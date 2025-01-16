using System;
using Npgsql;

namespace MonsterTradingCardsGame
{
    public static class DBHandler
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=postgres";

        public static void TestConnection()
        {
            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                connection.Open();
                Console.WriteLine("Verbindung zur Datenbank erfolgreich!");

                // Beispiel: Eine einfache Abfrage
                using var command = new NpgsqlCommand("SELECT * FROM person;", connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler bei der Datenbankverbindung: {ex.Message}");
            }
        }
    }
}