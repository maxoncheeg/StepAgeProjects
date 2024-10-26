using System.Drawing;

namespace LongDistanceService.Model.Main
{
    class Truck
    {
        public int Id { get; private set; }
        public string LicensePlate { get; private set; }
        public string Brand { get; set; }
        public int LoadCapacity { get; set; }
        public Image Photo { get; set; }
        public int OrderId { get; set; } = 0;
        public int TruckerId { get; set; } = 0;

        private Truck(int Id, string LicensePlate)
        {
            this.Id = Id;
            this.LicensePlate = LicensePlate;
        }

        public static Truck Create(string licensePlate, int id = 0) => new Truck(id, licensePlate);

        public string ToShortString() =>
            $"{LicensePlate}|{Brand}|{LoadCapacity}tons";

        public static string LicensePlateFromShortString(string shortString)
        {
            string licensePlate = "";

            for (int i = 0; i < 6; i++)
                licensePlate += shortString[i];

            return licensePlate;
        }
    }
}
