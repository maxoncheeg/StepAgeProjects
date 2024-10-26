using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex7_1
{
    class CardDeck
    {
        private ImageList _imageList { get; set; }

        private PictureBox _pictureBoxMain;
        private PictureBox _pictureBoxChanging;

        private Card _activeMainCard;
        private Card _activeChangingCard;

        private Random _random;

        private Card[] _cards;

        public CardDeck(ImageList _imageList, PictureBox _pictureBoxMain, PictureBox _pictureBoxChanging)
        {
            this._pictureBoxChanging = _pictureBoxChanging;
            this._pictureBoxMain = _pictureBoxMain;
            this._imageList = _imageList;

            _random = new Random();

            _activeMainCard = null;
            _activeChangingCard = null;

            _cards = new Card[_imageList.Images.Count];//чтобы можно было загрузить любой imageList

            for (int index = 0; index < _cards.Length; index++)
                _cards[index] = new Card(this._imageList.Images[index], index);           
        }

        public void ChangeMainPicture()
        {
            Card temporaryCard = CreateTemporaryCard(_activeMainCard);

            _pictureBoxMain.Image = temporaryCard.CardImage;
            _activeMainCard = temporaryCard;
        }

        public void ChangeChangingPicture()
        {
            Card temporaryCard = CreateTemporaryCard(_activeChangingCard);

            _pictureBoxChanging.Image = temporaryCard.CardImage;
            _activeChangingCard = temporaryCard;
        }

        private Card CreateTemporaryCard(Card _activeCard)
        {
            Card temporaryCard;

            if (_activeCard != null)
                do
                {
                    temporaryCard = _cards[_random.Next(0, _cards.Length)];
                } while (temporaryCard.CardValue == _activeCard.CardValue);
            else return _cards[_random.Next(0, _cards.Length)];

            return temporaryCard;
        }

        public bool IsMatch()
        {
            if (_activeChangingCard.CardValue == _activeMainCard.CardValue) return true;
            else return false;
        }
    }
}
