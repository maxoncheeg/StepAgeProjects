using System;

namespace SHARPex21_1
{
    abstract class Human
    {
        public bool IsWin { get; set; } = false;
        public int Money { get; set; } = 20000;
        public int HiddenRouletteNumber { get; set; } = 1;

        public abstract void SpinRoulette(object sender, EventArgs args);
    }
}
