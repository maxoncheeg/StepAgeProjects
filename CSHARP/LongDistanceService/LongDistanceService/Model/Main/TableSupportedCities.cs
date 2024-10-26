using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.Main
{
    class TableSupportedCities : ConnectionToSqlDB, ITable<SupportedCity>
    {
        public TableSupportedCities(string nameOfDataBase) : base(nameOfDataBase)
        {
            
        }

        public async Task<bool> AddAsync(SupportedCity item)
        {
            await _connection.OpenAsync();

            try
            {
                using(SqlCommand command = new SqlCommand($"insert into [SupportedCities] values ('{item.Country}', '{item.City}')", _connection))
                    if(await command.ExecuteNonQueryAsync() <= 0)
                    {
                        _connection.Close();
                        return false;
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

            using (SqlCommand command = new SqlCommand($"delete [SupportedCities] where [Id] = {id}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<SupportedCity>> SearchAsync(string name)
        {
            await _connection.OpenAsync();

            List<SupportedCity> cities = new List<SupportedCity>();

            using (SqlCommand command = new SqlCommand($"select * from [SupportedCities] where [City] like '%{name}%'", _connection))
            using(SqlDataReader dataReader = await command.ExecuteReaderAsync())
                while(await dataReader.ReadAsync())
                {
                    SupportedCity city = SupportedCity.Create(dataReader.GetInt32(0));
                    city.Country = dataReader.GetString(1);
                    city.City = dataReader.GetString(2);

                    cities.Add(city);
                }

            _connection.Close();
            return cities;
        }

        public async Task<bool> UpdateAsync(SupportedCity item)
        {
            await _connection.OpenAsync();

            try
            {
                using (SqlCommand command = new SqlCommand($"update [SupportedCities] set [Country] = '{item.Country}', [City] = '{item.City}' where [Id] = {item.Id}", _connection))
                    if (await command.ExecuteNonQueryAsync() <= 0)
                    {
                        _connection.Close();
                        return false;
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
