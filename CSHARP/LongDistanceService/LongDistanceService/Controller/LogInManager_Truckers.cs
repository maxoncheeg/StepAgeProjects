using LongDistanceService.Model;
using LongDistanceService.Model.Main;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongDistanceService.Controller
{
    partial class LogInManager
    {
        private ITable<Trucker> _tableTruckers;
        private List<Trucker> _truckers;

        public async Task<bool> RegisterAsTruckerAsync(string name, string numberPhone, string password, int experience, Image photo)
        {
            Trucker newTrucker = Trucker.Create(numberPhone, password);
            newTrucker.Name = name;
            newTrucker.Experience = experience;
            newTrucker.Photo = photo;

            return await _tableTruckers.AddAsync(newTrucker);
        }

        public async Task<DateTime> UpdateTruckersListAsync()
        {
            _truckers = await _tableTruckers.SearchAsync("");

            return DateTime.Now;
        }

        public async Task<bool> DeleteTruckerAsync(string numberPhone)
        {
            if (_truckers is null) return false;
            else if (_truckers.Count <= 0) return false;

            Trucker truckerOnDelete = null;

            foreach (var item in _truckers)
                if (item.NumberPhone == numberPhone)
                {
                    truckerOnDelete = item;
                    break;
                }


            if (truckerOnDelete is null) return false;
            else if (truckerOnDelete.Status == TruckerStatus.AwaitingApproval || truckerOnDelete.Status == TruckerStatus.AtWork) return false;

            return await _tableTruckers.DeleteAsync(truckerOnDelete.Id);
        }

        public List<Trucker> GetTruckers() => _truckers;

        public void GetTruckersToListAsync(ListBox list)
        {
            list.Items.Clear();
            _truckers.ForEach(trucker => list.Items.Add(trucker.NumberPhone));
        }

        public bool GetInfoAboutTruckerByNumberPhone(TextBox numberPhone, TextBox name, TextBox status, TextBox exp, TextBox orders, PictureBox photo)
        {
            if (_truckers is null) return false;
            else if (_truckers.Count <= 0) return false;

            Trucker trucker = null;

            foreach (var item in _truckers)
                if (item.NumberPhone == numberPhone.Text)
                {
                    trucker = item;
                    break;
                }

            if (trucker is null) return false;

            name.Text = trucker.Name;
            status.Text = trucker.Status.ToString();
            exp.Text = trucker.Experience.ToString();
            orders.Text = trucker.OrdersCompleted.ToString();
            photo.Image = trucker.Photo;

            return true;
        }

        public async Task<bool> LogInTruckerAsync(string numberPhone, string password)
        {
            List<Trucker> truckers = await _tableTruckers.SearchAsync(numberPhone);

            if (truckers is null) return false;

            foreach (var item in truckers)
                if (item.Password == password && item.NumberPhone == numberPhone)                
                    return true;
                
            return false;
        }

    }
}
