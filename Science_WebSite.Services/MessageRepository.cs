using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Dapper;

namespace Science_WebSite.Services
{
    public class MessageRepository : IMessageRepository
    {
        private string connectionString = "User ID=postgres; Password=postgres; Server=127.0.0.1; Port=5433; Database=Science_db";
        public void AddMessage(string message, int userId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO MessageData(textmessage, userid) VALUES('{message}', '{userId}')", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
