namespace LongDistanceService.Model.Main
{
    class Application
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public int TruckerId { get; set; }
        public int OrderId { get; set; }

        private Application(int Id) => this.Id = Id;

        public static Application Create(int id = 0) => new Application(id);
    }
}
