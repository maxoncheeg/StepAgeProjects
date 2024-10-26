namespace LongDistanceService.Model.Main
{
    enum OrderStatus
    {
        Awaiting = 1,
        InWork = 2
    }

    class Order
    {
        public int Id { get; private set; }
        public int CargoWeight { get; set; }
        public string Name { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 0;
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        private Order(int Id) => this.Id = Id;

        public static Order Create(int id = 0) => new Order(id);

        public void StatusFromString(string statusFromDB)
        {
            int index = 1;

            while (statusFromDB != ((OrderStatus)index).ToString())
                index *= 2;

            Status = (OrderStatus)index;
        }
    }
}
