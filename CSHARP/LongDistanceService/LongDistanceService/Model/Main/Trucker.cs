using System.Drawing;

namespace LongDistanceService.Model.Main
{
    enum TruckerStatus
    {
        Idling = 1,
        AwaitingApproval = 2,
        AtWork = 4
    }

    class Trucker
    {
        public int Id { get; private set; }
        public string NumberPhone { get; private set; }
        public string Password { get; private set; }
        public string Name { get; set; }
        public Image Photo { get; set; }
        public TruckerStatus Status { get; private set; }
        public int Experience { get; set; }
        public int OrdersCompleted { get; set; }

        private Trucker(int Id, string NumberPhone, string Password)
        {
            this.Id = Id;
            this.NumberPhone = NumberPhone;
            this.Password = Password;
        }

        public static Trucker Create(string numberPhone, string password, int id = 0) =>
            new Trucker(id, numberPhone, password);

        public void StatusFromString(string statusFromDB)
        {
            int index = 1;

            while (statusFromDB != ((TruckerStatus)index).ToString())
                index *= 2;

            Status = (TruckerStatus)index;
        }
    }
}
