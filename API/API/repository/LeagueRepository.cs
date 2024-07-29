using System.Data.Common;
using MySqlConnector;

namespace LeagueApi {
    public class LeagueRepository {
        private readonly MySqlDataSource _database;

        public LeagueRepository(MySqlDataSource database) {
            _database = database;
        }

        private async Task<IReadOnlyList<League>> ReadAllLeagueAsync(DbDataReader reader) {
            var posts = new List<League>(); 
            using (reader) 
            { 
                while (await reader.ReadAsync()) { 
                    var post = new League { 
                        Id = reader.GetInt32(0), 
                        leagueName = reader.GetString(1), 
                        leagueCountry = reader.GetString(2), 
                        leagueMaxCap = reader.GetInt32(3), 
                    }; 
                    posts.Add(post); 
                }
            }
            return posts; 
        }

        private static void BindParams(MySqlCommand cmd, League league) { 
            cmd.Parameters.AddWithValue("@name", league.leagueName); 
            cmd.Parameters.AddWithValue("@country", league.leagueCountry); 
            cmd.Parameters.AddWithValue("@maxCap", league.leagueMaxCap); 
        }

        private static void BindId(MySqlCommand cmd, League league) { 
            cmd.Parameters.AddWithValue("@id", league.Id); 
        }

        public async Task<League?> FindOneAsync(int id) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"SELECT * FROM league WHERE `leagueID` = @id"; 
            command.Parameters.AddWithValue("@id", id); 
            var result = await ReadAllLeagueAsync(await command.ExecuteReaderAsync()); 
            return result.FirstOrDefault(); 
        } 

        public async Task<List<League>> 
        GetAllLeagueAsync() {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"SELECT * FROM league";
            return (List<League>)await ReadAllLeagueAsync(await read.ExecuteReaderAsync());
        }

        public async Task InsertLeagueAsync(League league) {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"INSERT INTO league(`leagueName`, `leagueCountry`, `leagueMaxCap`) VALUES (@name, @country, @maxCap);";
            BindParams(read, league); 
            await read.ExecuteNonQueryAsync(); 
            league.Id = (int)read.LastInsertedId; 
        }

        public async Task UpdateAsync(League league) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand();
            command.CommandText = @"UPDATE league SET `leagueName` = @name, `leagueCountry` = @country, `leagueMaxCap` = @maxCap WHERE `leagueID` = @id;"; 
            BindParams(command, league);
            BindId(command, league);
            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(League league) {
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"DELETE FROM league WHERE `leagueID` = @id;"; 
            BindId(command, league); 
            await command.ExecuteNonQueryAsync();
        }
    }
}