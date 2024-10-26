using System;

namespace SHARPex21_1
{
    class RouletteNumber : EventArgs
    {
        public int Number { get; set; }

        private RouletteNumber() { }

        public static RouletteNumber CreateRandomNumber()
        {
            Random random = new Random();
            //ну это чисто для красоты, и из-за того, что C# не дает оставлять пустые ссылки
            return new RouletteNumber() { Number = random.Next(1, 9) };
        }
    }
}
