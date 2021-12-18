using System.Data.SqlClient;

string connectionString = File.ReadAllText("D:/Revature/ConnectionStrings/211115-SQL-DENNISK.txt");

//using SqlConnection connection = new(connectionString);
SqlConnection connection = new SqlConnection(connectionString);

connection.Open();

string commandText = "SELECT * FROM FormatPrice";

using SqlCommand command = new(commandText, connection);

using SqlDataReader reader = command.ExecuteReader();

while(reader.Read())
{
    string title = reader.GetString(0);
    string printFormat = reader.GetString(1);
    decimal price = reader.GetDecimal(2);

    Console.WriteLine($"The book \"{title}\" cost ${price} when printed as {printFormat}");
}