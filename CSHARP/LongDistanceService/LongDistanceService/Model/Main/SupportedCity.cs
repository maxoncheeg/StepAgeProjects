namespace LongDistanceService.Model.Main
{
    class SupportedCity
    {
        public int Id { get; private set; }
        public string Country { get; set; }
        public string City { get; set; }

        private SupportedCity(int Id) => this.Id = Id;

        public static SupportedCity Create(int id = 0) => new SupportedCity(id);

        public string ToShortString() => $"{Id}| {Country}, {City}";

        public static int IdByShortString(string shortString)
        {
            string result = "";
            int id;

            foreach (var simbol in shortString)
            {
                if (simbol == '|') break;

                result += simbol;
            }

            return int.TryParse(result, out id) ? id : 0;
        }
    }
}
