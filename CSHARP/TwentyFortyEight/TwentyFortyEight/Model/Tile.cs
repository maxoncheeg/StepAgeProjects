using System;

namespace TwentyFortyEight.Model
{
    public enum TileDenomination
    {
        Two = 2,
        Four = 4,
        Eight = 8,
        Sixteen = 16,
        ThirtyTwo = 32,
        SixtyFour = 64,
        OneHundredTwentyEight = 128,
        TwoHundredFiftySix = 256,
        FiveHundredTwelve = 512,
        TenTwentyFour = 1024,
        TwentyFortyEight = 2048
    }

    public class Tile
    {
        public TileDenomination Denomination { get; set; }

        private Tile(TileDenomination Denomination) =>
            this.Denomination = Denomination;
        
        public static Tile Create()
        {
            Random random = new Random();

            TileDenomination denomination = random.Next(0, 100) < 90 ?
                TileDenomination.Two : TileDenomination.Four;

            return new Tile(denomination);
        }

        public static Tile Create(TileDenomination denomination) =>
            new Tile(denomination);
    }
}
