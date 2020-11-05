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
        //private List<User> _userList; //начало псево бд
        //public UserRepository()
        //{
        //    _userList = new List<User>()
        //    {
        //        new User()
        //        {
        //           ID = 0, Name ="lena", LastName="kataeva", Email="lenkataeva@gmail.com", Login="leno4ka", Password="postgressql"
        //        },
        //        new User()
        //        {
        //           ID = 1, Name ="adilia", LastName="ebobo", Email="ebobolia@gmail.com", Login="ebkaka", Password="molly"
        //        },
        //        new User()
        //        {
        //           ID = 2, Name ="Ropa", LastName="Olegovich", Email="Ropapa@gmail.com", Login="RopaRopa", Password="finikiEtoVkusno"
        //        },
        //        new User()
        //        {
        //           ID = 3, Name ="Idi", LastName="Nahuy", Email="Vonyaesh@gmail.com", Login="Auf", Password="Blyat"
        //        }
        //    };

        //}
        //IEnumerable<User> IUserRepository.GetAllUsers()
        //{
        //    return _userList;
        //}

        ////IEnumerable<Article> IUserRepository.GetAllArticles()
        ////{
        ////    return _articleList;
        ////}

        //public User GetUser(int id)
        //{
        //    return _userList.FirstOrDefault(x => x.ID == id);
        //} //конец псевдо бд

        private string connectionString = "User ID=postgres; Password=postgres; Server=127.0.0.1; Port=5433; Database=Science_db";//"Driver={PostgreSQL ODBC Driver(UNICODE)}; Server=127.0.0.1; Host=localhost; Port=5433;Database=Science_db;UID=postgres;PWD=postgres"; 

        public void AddUser(User user)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO UserData(name, email, password) VALUES({user.Name}, {user.Email}, {user.Password})", connection);
                command.ExecuteNonQuery();
            }
            //await using (var connection = new NpgsqlConnection(connectionString))
            //{
            //    await connection.OpenAsync();
            //    connection.Execute(
            //        "INSERT INTO UserData (name, email, password) VALUES (@Name, @Email, @Password)",
            //        new {Name = user.Name, Email = user.Email, Password = user.Password });
            //}
        }

        public async Task GetUserId(string email, string password)
        {
            await using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                NpgsqlCommand command = new NpgsqlCommand($"SELECT id, name, email, password FROM UserData WHERE email = {email} AND password = {password}");
                var reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    int _id = reader.GetInt32(0);
                    string _name = reader.GetString(1);
                    string _email = reader.GetString(2);
                    string _paswword = reader.GetString(3);
                    
                }
            }
        }

        public async Task<User> GetUser(string email, string password)
        {
            await using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var user = connection.QueryFirstOrDefault<User>( //ферст ор дефолт - или первое значение в списке или дефолтное(??) и вернет тип указанный в <> то есть юзера! 
                    "select id, name, email, password, from UserData where email = @Email and password = @Password",
                    new { Email = email, Password = password }) ?? new User();
                return user;
            }
        }



        //public async Task UpdateUserUsername(int userId, string newUsername)
        //{
        //    var sql = "UPDATE users SET username = @Username WHERE id = @Id";
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        await connection.ExecuteAsync(sql, new { Username = newUsername, Id = userId });
        //    }
        //}

        //public async Task UpdateProfilePic(int userId, string imagePath)
        //{
        //    var sql = "UPDATE users SET imagepath = @ImagePath WHERE id = @Id";
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        await connection.ExecuteAsync(sql, new { ImagePath = imagePath, Id = userId });
        //    }
        //}

        //public async Task UpdateIsMember(int userId, bool isMember)
        //{
        //    var sql = "UPDATE users SET is_member = @IsMember WHERE id = @Id";
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        await connection.ExecuteAsync(sql, new { IsMember = isMember, Id = userId });
        //    }
        //}

        //public async Task<User> GetUserById(int id)
        //{
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var user = connection.QueryFirstOrDefault<User>(
        //            @"select id, email, password, username, is_member as IsMember, role_id as Role, imagePath as ImagePath, enter_key as Key from users where id = @Id",
        //            new { Id = id });
        //        return user;
        //    }
        //}

        //public async Task<User> GetUserByName(string username)
        //{
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var user = connection.QueryFirstOrDefault<User>(
        //            @"select id, email, password, username, is_member as IsMember, role_id as Role, imagePath as ImagePath, enter_key as Key from users where username = @Username",
        //            new { Username = username });
        //        return user;
        //    }
        //}

        //public async Task UpdateUserPassword(int userId, string newPassword)
        //{
        //    var sql = "UPDATE users SET password = crypt(@Password, gen_salt('bf')) where id = @Id";
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        await connection.ExecuteAsync(sql, new { Password = newPassword, Id = userId });
        //    }
        //}

        //public async Task<bool> IsPasswordMatch(int userId, string password)
        //{
        //    await using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var result = connection.ExecuteScalar<bool>(
        //            "select count(1) from users where id = @Id and password = crypt(@Password, password)",
        //            new { Id = userId, Password = password });
        //        return result;
        //    }
        //}

        //public async Task<List<User>> GetUsers()
        //{
        //    using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var usersList =
        //            connection.Query<User>(@"select id, email, username, imagepath as ImagePath from users").ToList();
        //        return usersList;
        //    }
        //}

        //public async Task<User> GetUserByEnterKey(string enterKey)
        //{
        //    await using (var connection = new NpgsqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var user = connection.QueryFirstOrDefault<User>(
        //            @"select id, email, password, username, is_member as IsMember, role_id as Role, imagePath as ImagePath, enter_key as Key from users where enter_key = @EnterKey",
        //            new { EnterKey = enterKey }) ?? new User();
        //        return user;
        //    }
        //}
    }
}
