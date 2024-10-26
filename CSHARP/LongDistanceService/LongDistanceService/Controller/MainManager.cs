using LongDistanceService.Model;
using LongDistanceService.Model.Main;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongDistanceService.Controller
{
    class MainManager
    {
        private static MainManager _manager;

        private ITable<Truck> _tableTrucks;
        private ITable<SupportedCity> _tableSupportedCities;
        private ITable<Order> _tableOrders;

        private List<Truck> _trucks;
        private List<SupportedCity> _supportedCities;

        private MainManager()
        {
            _manager = this;

            _tableTrucks = new TableTrucks("LDS_MAIN_DB");
            _tableSupportedCities = new TableSupportedCities("LDS_MAIN_DB");
            _tableOrders = new TableOrders("LDS_MAIN_DB");
        }

        public static MainManager GetManager() => _manager ?? new MainManager();

        public async Task<bool> AddNewTruckAsync(string licensePlate, string brand, int loadCapacity, Image photo)
        {
            Truck newTruck = Truck.Create(licensePlate);
            newTruck.Brand = brand;
            newTruck.LoadCapacity = loadCapacity;
            newTruck.Photo = photo;

            return await _tableTrucks.AddAsync(newTruck);
        }

        public async Task<Boolean> UpdateTruckListAsync()
        {
            _trucks = await _tableTrucks.SearchAsync("");

            return _trucks is null ? false : true;
        }

        public void GetSortedTruckList(ListBox list, bool isAscending, int sortVariant = 0)
        {
            if (_trucks.Count <= 0) return;

            list.Items.Clear();

            if (sortVariant == 0)
                _trucks.ForEach(truck => list.Items.Add(truck.ToShortString()));

            if (sortVariant == 1)
                _trucks.SortByLicensePlate(isAscending).ForEach(truck => list.Items.Add(truck.ToShortString()));
            else if (sortVariant == 2)
                _trucks.SortByBrand(isAscending).ForEach(truck => list.Items.Add(truck.ToShortString()));
            else if (sortVariant == 3)
                _trucks.SortByLoadCapacity(isAscending).ForEach(truck => list.Items.Add(truck.ToShortString()));
        }

        public async Task<bool> GetTruckByLicensePlateAsync(TextBox licensePlate, TextBox brand, NumericUpDown loadCapacity, TextBox trucker, TextBox order, PictureBox photo)
        {
            List<Truck> trucks = await _tableTrucks.SearchAsync(licensePlate.Text);

            if (trucks.Count != 1) return false;

            string truckerName = "none", orderName = "none";

            if (trucks[0].TruckerId != 0 && trucks[0].OrderId != 0)
            {
                LogInManager logInManager = LogInManager.GetManager();

                await logInManager.UpdateTruckersListAsync();
                //await ORDER               

                try
                {
                    truckerName = logInManager.GetTruckers().Where(x => x.Id == trucks[0].TruckerId).First().Name;
                }
                catch
                {
                    truckerName = "none";
                    orderName = "none";

                    return false;
                }
            }

            licensePlate.Text = trucks[0].LicensePlate;
            brand.Text = trucks[0].Brand;
            photo.Image = trucks[0].Photo;
            loadCapacity.Value = trucks[0].LoadCapacity;
            trucker.Text = truckerName;
            order.Text = orderName;

            return true;
        }

        public async Task<bool> UpdateTruckAsync(string licensePlate, int loadCapacity, Image photo)
        {
            List<Truck> trucks = await _tableTrucks.SearchAsync(licensePlate);

            if (trucks.Count != 1) return false;
            else if (trucks[0].TruckerId != 0) return false;

            trucks[0].Photo = photo;
            trucks[0].LoadCapacity = loadCapacity;

            return await _tableTrucks.UpdateAsync(trucks[0]); 
        }

        public async Task<bool> DeleteTruckAsync(string licensePlate)
        {
            List<Truck> trucks = await _tableTrucks.SearchAsync(licensePlate);

            if (trucks.Count != 1) return false;
            else if (trucks[0].TruckerId != 0) return false;

            return await _tableTrucks.DeleteAsync(trucks[0].Id);
        }

        public async Task GetSupportedCitiesAsync(ListBox list = null)
        {
            _supportedCities = await _tableSupportedCities.SearchAsync("");

            if (list is null) return;

            list.Items.Clear();
            foreach (var city in _supportedCities)
                list.Items.Add(city.ToShortString());
        }

        public async Task GetSupportedCitiesAsync(ComboBox comboBox = null)
        {
            _supportedCities = await _tableSupportedCities.SearchAsync("");

            if (comboBox is null) return;

            comboBox.Items.Clear();
            foreach (var city in _supportedCities)
                comboBox.Items.Add(city.ToShortString());
        }

        public async Task<bool> AddSupportedCityAsync(string country, string city)
        {
            SupportedCity supportedCity = SupportedCity.Create();
            supportedCity.Country = country;
            supportedCity.City = city;

            return await _tableSupportedCities.AddAsync(supportedCity);
        }

        public async Task<bool> DeleteSupportedCityAsync(string shortString)
        {
            int id = SupportedCity.IdByShortString(shortString);

            if (id == 0) return false;
            return await _tableSupportedCities.DeleteAsync(id);
        }

        public async Task<bool> MakeOrderAsync(string orderName, int cargoWeight, string description, string from, string to)
        {
            int fromId = SupportedCity.IdByShortString(from),
                toId = SupportedCity.IdByShortString(to);

            Order order = Order.Create();
            order.Name = orderName;
            order.CargoWeight = cargoWeight;
            order.From = fromId;
            order.To = toId;
            order.Description = description;

            return await _tableOrders.AddAsync(order);
        }
    }
}
