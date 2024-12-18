using System;
using System.Data.SqlClient;

class Program {
    static void Main(string[] args) {
        //string queryDB = "CREATE DATABASE StoreDB";
        string queryCat = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'StoreDB') " + "BEGIN CREATE DATABASE StoreDB END";

        string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        //string queryCat = "CREATE TABLE Categories (pk_cat INT PRIMARY KEY IDENTITY, nom_cat NVARCHAR(100) NOT NULL)";

        string queryProd = @"CREATE TABLE Produits (pk_pro INT PRIMARY KEY IDENTITY, 
                nom_pro NVARCHAR(100) NOT NULL,
                quantite_pro INT NOT NULL,
                prix_pro DECIMAL(18, 2) NOT NULL,
                fk_cat INT NOT NULL,
                FOREIGN KEY (fk_cat) REFERENCES Categories(pk_cat)
            )";

        string insertCat = @"
            INSERT INTO Categories (nom_cat) VALUES
            ('Electronique'), 
            ('Vêtements'), 
            ('Meubles')";

        string insertProd = @"
            INSERT INTO Produits (nom_pro, quantite_pro, prix_pro, fk_cat) VALUES
            ('Télévision', 10, 499.99, 1), 
            ('Ordinateur Portable', 5, 899.99, 1), 
            ('Chaise', 15, 79.99, 3), 
            ('Canapé', 8, 499.99, 3), 
            ('T-shirt', 50, 19.99, 2), 
            ('Pantalon', 30, 39.99, 2)";

        using (SqlConnection connection = new SqlConnection(connectionString)) {
            SqlCommand command = new SqlCommand(queryDB, connection);
            try {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Base de données crée.");

                command = new SqlCommand("USE StoreDB", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand(queryCat, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table 'Categories' créée.");

                command = new SqlCommand(queryProd, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table 'Produits' créé.");

                command = new SqlCommand(insertCat, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Catégories insérées.");

                command = new SqlCommand(insertProd, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Produits insérés.");
            }
            catch (SqlException ex) {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}