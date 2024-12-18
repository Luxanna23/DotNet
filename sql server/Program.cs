using System;
using System.Data.SqlClient;

class Program {
    static void Main(string[] args) {
        string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        string query = "CREATE TABLE Livre (id INT PRIMARY KEY IDENTITY, titre NVARCHAR(100) NOT NULL, annee INT NOT NULL,)";

        using (SqlConnection connection = new SqlConnection(connectionString)) {
            SqlCommand command = new SqlCommand(query, connection);
            try {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Base de données crée.");
            }
            catch (SqlException ex) {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}