using Microsoft.Win32.SafeHandles;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace sql
{
    internal class Program
    {

        public static string StrConn => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test_2;Integrated Security=True;Connect Timeout=30;";

        private SqlConnection _conn;
        static void Main(string[] args)
        {
            

            //Console.WriteLine("Enter first name: ");
            //string? FirstName = Console.ReadLine();

            //Console.WriteLine("Enter last name: ");
            //string? LastName = Console.ReadLine();

            //Console.WriteLine("Enter e-mail: ");
            //string? Email = Console.ReadLine();

            //Console.WriteLine("Enter  date of birth: ");
            //string? DateOfBirth = Console.ReadLine();

            //_conn = SqlConnection(StrConn);


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                var query = "SELECT * FROM Users"; 
                var cmd = new SqlCommand(query, conn);

                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{ reader["first_name"]}, { reader["last_name"]}, { reader["e_mail"]}, { reader["date_of_birth"]}");
                    }

                }

                conn.Close();
            }


            //InsertQeury(FirstName, LastName, Email, DateOfBirth);
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test_2;Integrated Security=True;Connect Timeout=30;
            //Data Source=DESKTOP-BIUF6L3\SQLEXPRESS;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;

            var sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BIUF6L3\SQLEXPRESS;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;");

            Console.WriteLine("Hello, World!");

        }

        static void InsertQeury(string? FirstName, string? LastName, string? Email, string? DateOfBirth)
        {
            try
            {

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
