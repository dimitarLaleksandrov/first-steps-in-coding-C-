using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=DESKTOP-LLKQ9MN;Database=SoftUni;Integrated Security=true;TrustServerCertificate=True;");  

connection.Open();
using (connection)
{
    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Employees", connection);
    int? employeescount = (int?) await command.ExecuteScalarAsync();

    Console.WriteLine(employeescount);
}