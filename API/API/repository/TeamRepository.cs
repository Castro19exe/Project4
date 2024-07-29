using System.Data.Common;
using MySqlConnector;

namespace TeamApi {
    public class TeamRepository {
        private readonly MySqlDataSource _database;

        public TeamRepository(MySqlDataSource database) {
            _database = database;
        }

        private async Task<IReadOnlyList<Team>> ReadAllTeamAsync(DbDataReader reader) {
            var posts = new List<Team>(); 
            using (reader) 
            { 
                while (await reader.ReadAsync()) { 
                    var post = new Team { 
                        Id = reader.GetInt32(0), 
                        teamName = reader.GetString(1), 
                    }; 
                    posts.Add(post); 
                }
            }
            return posts; 
        }

        private static void BindParams(MySqlCommand cmd, Team team) { 
            cmd.Parameters.AddWithValue("@name", team.teamName); 
            cmd.Parameters.AddWithValue("@fkidLeague", team.FkIdLeague); 
        }

        private static void BindId(MySqlCommand cmd, Team team) { 
            cmd.Parameters.AddWithValue("@id", team.Id); 
        }

        public async Task<Team?> FindOneAsync(int id) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"SELECT * FROM team WHERE `teamID` = @id"; 
            command.Parameters.AddWithValue("@id", id); 
            var result = await ReadAllTeamAsync(await command.ExecuteReaderAsync()); 
            return result.FirstOrDefault(); 
        } 

        public async Task<List<Team>> GetAllTeamAsync() {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"SELECT * FROM team";
            return (List<Team>)await ReadAllTeamAsync(await read.ExecuteReaderAsync());
        }

        public async Task InsertTeamAsync(Team team) {
            using var connection = await _database.OpenConnectionAsync();
            using var read = connection.CreateCommand();
            read.CommandText = @"INSERT INTO team(`teamName`, `FkLeagueID`) VALUES (@name, @fkidLeague);";
            BindParams(read, team);
            await read.ExecuteNonQueryAsync(); 
            team.Id = (int)read.LastInsertedId; 
        }

        public async Task UpdateAsync(Team team) { 
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand();
            command.CommandText = @"UPDATE team SET `teamName` = @name, `FkLeagueID` = @fkidLeague WHERE `teamID` = @id;";
            BindParams(command, team);
            BindId(command, team);
            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(Team team) {
            using var connection = await _database.OpenConnectionAsync(); 
            using var command = connection.CreateCommand(); 
            command.CommandText = @"DELETE FROM team WHERE `teamID` = @id;"; 
            BindId(command, team); 
            await command.ExecuteNonQueryAsync();
        }
    }
}