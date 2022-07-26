using georgelucasgomes_d3_avaliacao.Domain.Interfaces;
using georgelucasgomes_d3_avaliacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace georgelucasgomes_d3_avaliacao.Domain.Repositories
{
    internal class UserRepository : IUser
    {
        private readonly string connectionString = "Data source=ACCT-WS; initial catalog=georgelucasgomes_d3_avaliacao; user=sa; pwd=#Minhabenga15;";

        public User UserLogin(string email, string password)
        {
            User storedUser = new User();

            //Auto manage resources (open, close)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string querySelectAll = "SELECT id_user, name_user, email_user from tb_users where password_user = @password_user and email_user = @email_user";

                SqlDataReader reader;

                using (SqlCommand query = new SqlCommand(querySelectAll, connection))
                {
                    query.Parameters.AddWithValue("@password_user", password);
                    query.Parameters.AddWithValue("@email_user", email);

                    connection.Open();
                    reader = query.ExecuteReader();

                    while (reader.Read())
                    {
                        storedUser = new User()
                        {
                            UserId = Guid.Parse(reader["id_user"].ToString()),
                            UserName = reader["name_user"].ToString(),
                            UserEmail = reader["email_user"].ToString()
                        };
                    }
                }
            }

            return storedUser;
        }
    }
}
