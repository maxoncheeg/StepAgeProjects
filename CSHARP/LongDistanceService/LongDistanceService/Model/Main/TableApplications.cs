using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.Main
{
    class TableApplications : ConnectionToSqlDB, ITable<Application>
    {
        public TableApplications(string nameOfDataBase) : base(nameOfDataBase)
        {
        }

        public async Task<bool> AddAsync(Application item)
        {
            await _connection.OpenAsync();

            using (SqlCommand command = new SqlCommand($"insert into [applications] values" +
                                                      $"('{item.Description}', {item.OrderId}, {item.OrderId})", _connection))
                if(await command.ExecuteNonQueryAsync() <= 0)
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

            using(SqlCommand command = new SqlCommand($"delete [applications] where [Id] = {id}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<Application>> SearchAsync(string name)
        {
            await _connection.OpenAsync();

            List<Application> applications = new List<Application>();

            using(SqlCommand command = new SqlCommand("select * from [applications]"))
             using(SqlDataReader dataReader = await command.ExecuteReaderAsync())
                while(await dataReader.ReadAsync())
                {
                    Application application = Application.Create(dataReader.GetInt32(0));
                    application.Description = dataReader.GetString(1);
                    application.OrderId = dataReader.GetInt32(2);
                    application.TruckerId = dataReader.GetInt32(3);

                    applications.Add(application);
                }

            return applications;
        }

        public async Task<bool> UpdateAsync(Application item)
        {
            await _connection.OpenAsync();

            using(SqlCommand command = new SqlCommand($"update [applications] set" +
                                                        $"[Description] = '{item.Description}'," +
                                                        $"[OrderId] = {item.OrderId}," +
                                                        $"[TruckerId] = {item.TruckerId}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }
    }
}
