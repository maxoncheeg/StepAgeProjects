using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.LogIn
{
    class TableUsers : ConnectionToSqlDB, ITable<User>
    {
        public TableUsers(string nameOfDataBase) : base(nameOfDataBase)
        {
        }

        public async Task<bool> AddAsync(User item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"insert into [users] values ('{item.Login}', '{item.Password}', '{item.Name}', '{item.Description}', {(item.Photo is null ? "null" : "@photo")}, 0,  2)", _connection))
                {
                    if(item.Photo != null) 
                        command.Parameters.Add("@photo", System.Data.SqlDbType.Image).Value = item.Photo.ToByteArray();

                    if (await command.ExecuteNonQueryAsync() <= 0)
                    {
                        _connection.Close();
                        return false;
                    }
                }
            }
            catch
            {
                _connection.Close(); //если вылетит ошибка UNIQUE KEY
                return false;
            }

            _connection.Close();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _connection.OpenAsync();

            using (SqlCommand command = new SqlCommand($"delete [users] where [Id] = {id}", _connection))            
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<User>> SearchAsync(string name)
        {
            await _connection.OpenAsync();

            List<User> users = new List<User>();

            using (SqlCommand command = new SqlCommand($"select [users].[Id], [users].[Login], [users].[Password], [access_rights].[Name], [users].[Name], [users].[Description], [users].[Photo], [users].[OrdersMade] " +
                                                      $"from [users] inner join [access_rights] on [access_rights].[Id] = [users].[AccessRights] " +
                                                      $"where [Login] like '%{name}%'", _connection))
            using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                while (await dataReader.ReadAsync())
                {
                    User user = User.Create(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(0));
                    user.Name = dataReader.GetString(4);
                    user.Description = dataReader.GetString(5);

                    //if(dataReader.GetSqlBinary(6).ToString() == "NULL")

                    if (dataReader.GetSqlBinary(6).IsNull) 
                        user.Photo = null;
                    else
                        user.Photo = dataReader.GetSqlBytes(6).Value.ToImage();

                    user.OrdersMade = dataReader.GetInt32(7);

                    users.Add(user);
                }

            _connection.Close();
            return users;
        }

        public async Task<bool> UpdateAsync(User item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"update [users] set [Login] = '{item.Login}', [Password] = '{item.Password}', " +
                                                          $"[Name] = '{item.Name}', [Description] = '{item.Description}', [Photo] = {(item.Photo == null ? "null" : "@photo")}, [OrdersMade] = {item.OrdersMade}" +
                                                          $"where [Id] = {item.Id}", _connection))
                {
                    if (item.Photo != null)
                    {
                        byte[] image = item.Photo.ToByteArray();
                        command.Parameters.Add("@photo", System.Data.SqlDbType.VarBinary, image.Length).Value = image;
                    }

                    if (await command.ExecuteNonQueryAsync() <= 0)
                    {
                        _connection.Close();
                        return false;
                    }
                }
            }
            catch
            {
                _connection.Close();
                return false;
            }

            _connection.Close();
            return true;
        }
    }
}
