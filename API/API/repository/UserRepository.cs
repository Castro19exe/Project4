using System.Data.Common;
using MySqlConnector;

namespace UserApi {
    public class UserRepository {
        private readonly MySqlDataSource _database;

        public UserRepository(MySqlDataSource database) {
            _database = database;
        }

        private async Task<IReadOnlyList<User>> ReadAllUserAsync(DbDataReader reader) {
            var posts = new List<User>(); 
            using (reader) 
            { 
                while (await reader.ReadAsync()) { 
                    var post = new User { 
                        Id = reader.GetInt32(0), 
                        Name = reader.GetString(1), 
                        Password = reader.GetString(2), 
                        Role = reader.GetString(3), 
                    }; 
                    posts.Add(post); 
                }
            }
            return posts; 
        }

        private static void BindParams(MySqlCommand cmd, User user) { 
            cmd.Parameters.AddWithValue("@name", user.Name); 
            cmd.Parameters.AddWithValue("@password", user.Password); 
            cmd.Parameters.AddWithValue("@role", user.Role); 
        }

        private static void BindId(MySqlCommand cmd, User user) { 
            cmd.Parameters.AddWithValue("@id", user.Id); 
        }

        public async Task<User?> FindOneAsync(int id) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"SELECT * FROM user WHERE `userID` = @id"; 
            command.Parameters.AddWithValue("@id", id); 
            var result = await ReadAllUserAsync(await command.ExecuteReaderAsync()); 
            return result.FirstOrDefault(); 
        } 

        public async Task<User?> GetUserByName(string name) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"SELECT * FROM user WHERE `userName` = @name"; 
            command.Parameters.AddWithValue("@name", name); 
            var result = await ReadAllUserAsync(await command.ExecuteReaderAsync()); 
            return result.FirstOrDefault(); 
        } 

        public async Task<List<User>> GetAllUserAsync() {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"SELECT * FROM user";
            return (List<User>)await ReadAllUserAsync(await read.ExecuteReaderAsync());
        }

        public async Task InsertUserAsync(User user) {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"INSERT INTO user(`userName`, `userPassword`, `userRole`) VALUES (@name, @password, @role);";
            BindParams(read, user);
            await read.ExecuteNonQueryAsync();
            user.Role = "Normal";
            user.Id = (int)read.LastInsertedId;
        }

        public async Task UpdateUserAsync(User user) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand();
            command.CommandText = @"UPDATE user SET `userName` = @name, `userPassword` = @password, `userRole` = @role WHERE `userID` = @id;";
            BindParams(command, user);
            BindId(command, user);
            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteUserAsync(User user) {
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"DELETE FROM user WHERE `userID` = @id;"; 
            BindId(command, user); 
            await command.ExecuteNonQueryAsync();
        }
    }
}