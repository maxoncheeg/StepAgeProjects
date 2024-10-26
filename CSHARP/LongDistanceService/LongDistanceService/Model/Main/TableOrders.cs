using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LongDistanceService.Model.Main
{
    class TableOrders : ConnectionToSqlDB, ITable<Order>
    {
        public TableOrders(string nameOfDataBase) : base(nameOfDataBase)
        {
        }

        public async Task<bool> AddAsync(Order item)
        {
            await _connection.OpenAsync();
            

            using (SqlCommand command = new SqlCommand($"insert into [orders] values" +
                                        $"('{item.Name}', {item.CargoWeight}, {item.From}, {item.To}, " +
                                        $" '{item.Description}', '{OrderStatus.Awaiting}')", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
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

            using (SqlCommand command = new SqlCommand($"delete [orders] where [Id] = {id}", _connection))
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    _connection.Close();
                    return false;
                }

            _connection.Close();
            return true;
        }

        public async Task<List<Order>> SearchAsync(string name)
        {
            await _connection.OpenAsync();

            List<Order> orders = new List<Order>();

            using (SqlCommand command = new SqlCommand($"select * from [orders] where [Name] like '%{name}%'", _connection))
            using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                while(await dataReader.ReadAsync())
                {
                    Order order = Order.Create(dataReader.GetInt32(0));
                    order.Name = dataReader.GetString(1);
                    order.CargoWeight = dataReader.GetInt32(2);
                    order.From = dataReader.GetSqlInt32(3).IsNull ? 0 : dataReader.GetInt32(3);
                    order.To = dataReader.GetSqlInt32(4).IsNull ? 0 : dataReader.GetInt32(4);
                    order.Description = dataReader.GetString(5);
                    order.StatusFromString(dataReader.GetString(6));

                    orders.Add(order);
                }

            _connection.Close();
            return orders;
        }

        public async Task<bool> UpdateAsync(Order item)
        {
            await _connection.OpenAsync();

            using (SqlCommand command = new SqlCommand($"update [orders] set " +
                                                       $"[Name] = '{item.Name}," +
                                                       $"[CargoWeight] = {item.CargoWeight}," +
                                                       $"[From] = {item.From}," +
                                                       $"[To] = {item.To}," +
                                                       $"[Description] = '{item.Description}'," +
                                                       $"[Status] = '{item.Status}'", _connection))
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
