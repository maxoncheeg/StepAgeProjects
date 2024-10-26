using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.Main
{
    class TableTrucks : ConnectionToSqlDB, ITable<Truck>
    {
        public TableTrucks(string nameOfDataBase) : base(nameOfDataBase)
        {
        }

        public async Task<bool> AddAsync(Truck item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"insert into [trucks] values ('{item.LicensePlate}', '{item.Brand}', {item.LoadCapacity}, {(item.Photo is null ? "null" : "@photo")}, null, null)", _connection))
                {
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

            using(SqlCommand command = new SqlCommand($"delete [trucks] where [Id] = {id}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<Truck>> SearchAsync(string licensePlate)
        {
            await _connection.OpenAsync();

            List<Truck> trucks = new List<Truck>();

            using (SqlCommand command = new SqlCommand($"select * from [trucks] where [LicensePlate] like '%{licensePlate}%'", _connection))
            using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                while(await dataReader.ReadAsync())
                {
                    Truck truck = Truck.Create(dataReader.GetString(1), dataReader.GetInt32(0));

                    truck.Brand = dataReader.GetString(2);
                    truck.LoadCapacity = dataReader.GetInt32(3);
                    truck.Photo = dataReader.GetSqlBinary(4).IsNull ? null : dataReader.GetSqlBytes(4).Value.ToImage();
                    truck.OrderId = dataReader.GetSqlInt32(5).IsNull ? 0 : dataReader.GetInt32(5);
                    truck.TruckerId = dataReader.GetSqlInt32(6).IsNull ? 0 : dataReader.GetInt32(6);

                    trucks.Add(truck);
                }

            _connection.Close();
            return trucks;
        }

        public async Task<bool> UpdateAsync(Truck item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"update [trucks] set [LicensePlate] = '{item.LicensePlate}', [Brand] = '{item.Brand}', " +
                                                          $"[LoadCapacity] = {item.LoadCapacity},{(item.OrderId == 0 ? "" : $"[OrderId] = { item.OrderId }, ")}{(item.TruckerId == 0 ? "" : $"[TruckerId] = { item.OrderId }, ")} [Photo] = {(item.Photo is null ? "null" : "@photo")}" +
                                                          $" where [Id] = {item.Id}", _connection))
                {
                    if (item.Photo != null)
                    {
                        byte[] image = item.Photo.ToByteArray();
                        command.Parameters.Add("@photo", System.Data.SqlDbType.Image, image.Length).Value = image;
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
