using Science_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace Science_WebSite.Services
{
    public class UserRepository : IUserRepository
    {
        private string connectionString = "User ID=postgres; Password=postgres; Server=127.0.0.1; Port=5433; Database=Science_db";//"Driver={PostgreSQL ODBC Driver(UNICODE)}; Server=127.0.0.1; Host=localhost; Port=5433;Database=Science_db;UID=postgres;PWD=postgres"; 

        public void AddUser(User user)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO UserData(name, email, password) " +
                    $"VALUES('{user.Name}', '{user.Email}', '{user.Password}')", connection);
                command.ExecuteNonQuery();
            }
        }

        public User GetUser(string email, string password)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"SELECT id, name, email, password FROM UserData WHERE email = '{email}' AND password = '{password}'", connection);
                var user = connection.QueryFirstOrDefault<User>(
                    command.CommandText, new { Email = email, Password = password }) ?? new User();
                return user;
            }
        }

        public User GetUserByID(int id) 
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"SELECT id, name, email, password FROM UserData WHERE id = {id}", connection);
                var user = connection.QueryFirstOrDefault<User>(
                    command.CommandText, new { Id = id }) ?? new User();
                return user;
            }
        }

        public IEnumerable<User> GetAllUsers() 
        {
            using (var connection = new NpgsqlConnection(connectionString)) 
            {
                connection.Open();
                List<User> userlist = new List<User>();
                var command = new NpgsqlCommand("SELECT id, name, email, password FROM UserData", connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetValue(0));
                        string name = (string)reader.GetValue(1);
                        string email = (string)reader.GetValue(2);
                        string password = (string)reader.GetValue(3);
                        userlist.Add(new User() { ID = id, Name = name, Email = email, Password = password });
                    }
                }
                reader.Close();
                return userlist;
            }
        }
        public bool IsMember(string email, string password) 
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var userlist = GetAllUsers();
                bool check = false;
                foreach (var user_ in userlist)
                    if (user_.Email.Equals(email) && user_.Password.Equals(password))
                     check = true;
                return check;
            }
        }
    
    }
}
