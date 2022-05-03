using System.Data.SqlClient;
using VotingSystemProject.Models;
using Microsoft.AspNetCore.Http;

namespace VotingSystemProject.Services
{
    public class UsersDAO
    {

        public string connectionString = "Data Source=DESKTOP-JAVGDES;Initial Catalog=VotingSystemProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool FindUserByNameAndPassword(UserModel user)
        {
            bool success = false;

            string sqlStatement = "SELECT * FROM dbo.users WHERE name = @name AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50).Value = user.Name;

                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

            
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Session[]
                        }
                        success = true;



                        Session["Username"] = reader.GetValue(1).ToString(); 
                    }
                }catch (Exception f)
                {
                    Console.WriteLine(f.Message);

                }

            }
            return success;


        }
    }
}
