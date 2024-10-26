using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDS_KEYGEN_OFFICIAL.Model.LogIn
{
    enum UserAccessRights
    {
        admin, customer
    }

    class User
    {
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string AccessRights { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrdersMade { get; set; }        
        public Image Photo { get; set; }
      
        private User(int Id, string Login, string Password, string AccessRights)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.AccessRights = AccessRights;
        }

        public static User Create(string login, string password, string accessRights, int id = 0) =>
            new User(id, login, password, accessRights);

        public void ChangeLogin(string login) => Login = login;

        public void ChangePassword(string password) => Password = password;
    }
}
