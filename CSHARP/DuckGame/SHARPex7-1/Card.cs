using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPex7_1
{
    class Card
    {
        public Image CardImage { get; private set; }
        public int CardValue { get; private set; }

        public Card(Image CardImage, int CardValue)
        {
            this.CardImage = CardImage;
            this.CardValue = CardValue;
        }
    }
}
