using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LongDistanceService.Model;
using LongDistanceService.Model.LogIn;
using LongDistanceService.Model.Main;

namespace LongDistanceService.Controller
{
    partial class LogInManager : IDisposable
    {
        private static LogInManager _manager;

        private ITable<User> _tableUsers;
        private List<User> _users;

        private User _currentUser;
        
        private LogInManager()
        {
            _tableUsers = new TableUsers("LDS_USERS_DB");
            _tableTruckers = new TableTruckers("LDS_MAIN_DB");

            _manager = this;
        }

        public static LogInManager GetManager() => _manager ?? new LogInManager();

        public async Task<bool> LogInAsync(string login, string password)
        {
            List <User>  users = await _tableUsers.SearchAsync(login);

            if (users is null) return false;

            foreach (var item in users)
                if (item.Password == password && item.Login == login)
                {
                    _currentUser = item;
                    await _tableUsers.UpdateAsync(_currentUser);
                    return true;
                }
            
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Положительное число - Пользователь является админом. 0 - Пользователь является заказчиком. Отрицательное число - Пользователь не загружен из базы данных.</returns>
        public int GetCurrentUserAccessRight()
        {
            if (_currentUser is null) return -1;
            else if (_currentUser.AccessRights == UserAccessRights.admin.ToString()) return 1;
            else return 0;
        }

        public string GetCurrentUserLogin() => _currentUser.Login;

        public async Task<bool> RegisterAsCustomerAsync(string login, string password,string name, string description, Image photo)
        {
            User newUser = User.Create(login, password, UserAccessRights.customer.ToString());
            newUser.Description = description;
            newUser.Photo = photo;
            newUser.Name = name;

            return await _tableUsers.AddAsync(newUser);        
        }

        public async Task<DateTime> GetUsersAsync(ListBox list)
        {
            _users = await _tableUsers.SearchAsync("");

            list.Items.Clear();
            _users.ForEach(user => list.Items.Add(user.Login));

            return DateTime.Now;
        }

        public bool GetInfoAboutUsers(int index, TextBox login, TextBox name, TextBox access, TextBox ordersMade, TextBox description, PictureBox pictureBox)
        {
            if (_users.Count <= index) return false;

            login.Text = _users[index].Login;
            name.Text = _users[index].Name;
            access.Text = _users[index].AccessRights;
            ordersMade.Text = _users[index].OrdersMade.ToString();
            description.Text = _users[index].Description;
            pictureBox.Image = _users[index].Photo;

            return true;
        }

        public async Task<bool> UpdateUserInfoAsync(string login, bool deleteDescription, bool deleteName, bool deletePhoto)
        {
            User userOnUpdate = _users.FirstOrDefault(user => user.Login == login);

            if (userOnUpdate is null) return false;

            if (deleteDescription) userOnUpdate.Description = string.Empty;
            if (deleteName) userOnUpdate.Name = string.Empty;
            if (deletePhoto) userOnUpdate.Photo = null;

            return await _tableUsers.UpdateAsync(userOnUpdate);

        }

        public async Task<bool> DeleteUserAsync(string login)
        {
            if (_users.Count <= 0) return false;

            User userOnDelete = _users.FirstOrDefault(user => user.Login == login);

            if (userOnDelete is null) return false;

            return await _tableUsers.DeleteAsync(userOnDelete.Id);
        }

        public void GetCurrentUserInfo(TextBox login, TextBox password, TextBox name, TextBox accessRight, TextBox ordersMade, TextBox description, PictureBox photo)
        {
            if (_currentUser is null) return;

            login.Text = _currentUser.Login;
            password.Text = _currentUser.Password;
            name.Text = _currentUser.Name;
            ordersMade.Text = _currentUser.OrdersMade.ToString();
            description.Text = _currentUser.Description;
            accessRight.Text = _currentUser.AccessRights;
            photo.Image = _currentUser.Photo;
        }

        public async Task<bool> UpdateCurrentUserAsync(TextBox login, TextBox password, TextBox name, TextBox description, PictureBox photo)
        {
            _currentUser.ChangeLogin(login.Text);
            _currentUser.ChangePassword(password.Text);
            _currentUser.Name = name.Text;
            _currentUser.Description = description.Text;
            _currentUser.Photo = photo.Image;

            return await _tableUsers.UpdateAsync(_currentUser);
        }

        public async Task<bool> DeleteCurrentUserAsync() =>
            await _tableUsers.DeleteAsync(_currentUser.Id);

        public async Task<bool> AddOrderMadeToCurrentUser()
        {
            _currentUser.OrdersMade++;

            return await _tableUsers.UpdateAsync(_currentUser);
        }

        public void Dispose()
        {
            (_tableUsers as TableUsers).Dispose();
        }
    }
}
