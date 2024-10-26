using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.Main
{
    class TableTruckers : ConnectionToSqlDB, ITable<Trucker>
    {
        public TableTruckers(string nameOfDataBase) : base(nameOfDataBase)
        {
        }

        public async Task<bool> AddAsync(Trucker item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"insert into [truckers] values (@name, " +
                                                          $"@phoneNumber, @password, {(item.Photo is null ? "null" : "@photo")}," +
                                                          $" @status, @experience, 0)", _connection))
                {
                    command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = item.Name;
                    command.Parameters.Add("@phoneNumber", System.Data.SqlDbType.NVarChar).Value = item.NumberPhone;
                    command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = item.Password;
                    command.Parameters.Add("@status", System.Data.SqlDbType.NVarChar).Value = TruckerStatus.Idling.ToString();
                    command.Parameters.Add("@experience", System.Data.SqlDbType.Int).Value = item.Experience;

                    if (item.Photo != null)
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
                _connection.Close();
                return false;
            }

            _connection.Close();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _connection.OpenAsync();

            using(SqlCommand command = new SqlCommand($"delete [truckers] where [Id] = {id}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<Trucker>> SearchAsync(string numberPhone)
        {
            await _connection.OpenAsync();

            List<Trucker> truckers = new List<Trucker>();

            using (SqlCommand command = new SqlCommand($"select * from [truckers] where [PhoneNumber] like '%{numberPhone}%'", _connection))
            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                while(await reader.ReadAsync())
                {
                    Trucker trucker = Trucker.Create(reader.GetString(2), reader.GetString(3), reader.GetInt32(0));
                    trucker.Name = reader.GetString(1);
                    trucker.Photo = reader.GetSqlBytes(4).IsNull ? null : reader.GetSqlBytes(4).Value.ToImage();
                    trucker.StatusFromString(reader.GetString(5));
                    trucker.Experience = reader.GetInt32(6);
                    trucker.OrdersCompleted = reader.GetInt32(7);

                    truckers.Add(trucker);
                }

            _connection.Close();
            return truckers;
        }

        public async Task<bool> UpdateAsync(Trucker item)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"update [truckers] set [Name] = @name, [PhoneNumber] = @phoneNumber," +
                                                           $"[Password] = @password, [Status] = @status," +
                                                           $"[Experience] = @experience, [Photo] = {(item.Photo is null ? "null" : "@photo")}", _connection))
                {
                    command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = item.Name;
                    command.Parameters.Add("@phoneNumber", System.Data.SqlDbType.NVarChar).Value = item.NumberPhone;
                    command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = item.Password;
                    command.Parameters.Add("@status", System.Data.SqlDbType.NVarChar).Value = item.Status.ToString();
                    command.Parameters.Add("@experience", System.Data.SqlDbType.Int).Value = item.Experience;

                    if (item.Photo != null)
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
                _connection.Close();
                return false;
            }

            _connection.Close();
            return true;
        }
    }
}
