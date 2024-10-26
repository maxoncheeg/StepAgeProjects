using System;

namespace SHARPex21_1
{
    class Player : Human
    {
        public override void SpinRoulette(object sender, EventArgs args)
        {
            if (sender is Roulette && args is RouletteNumber)
            {
                RouletteNumber rouletteNumber = args as RouletteNumber;

                if (rouletteNumber.Number == HiddenRouletteNumber)
                    IsWin = true;
            }
        }
    }
    class Enemy : Human 
    {
        public override void SpinRoulette(object sender, EventArgs args)
        {
            if (sender is Roulette && args is RouletteNumber)
            {
                RouletteNumber rouletteNumber = args as RouletteNumber;
                Random random = new Random();

                HiddenRouletteNumber = random.Next(1, 9);

                if (rouletteNumber.Number == HiddenRouletteNumber)
                    IsWin = true;
            }
        }
    }
}
