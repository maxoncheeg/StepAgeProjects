using System;
using System.Threading;
using System.Windows.Forms;

namespace SHARPex21_1
{
    class Roulette
    {
        public event EventHandler RouletteWheel;

        public bool IsThreadActive { get; set; }
        public int Bet { get; set; }

        public void SpinTheRouletteWheel(PictureBox roulette, ImageList rouletteNumbers)
        {
            if (RouletteWheel != null)
            {
                Random random = new Random();
                int randomNumber = random.Next(50, 80);

                IsThreadActive = true;

                Thread thread = new Thread(() =>
                {//Пытался приостанавливать поток самого приложения Thread.Sleep(), но оказывается, что так
                    for (int i = 0, number = 1; i < randomNumber; i++, number++)//оно намертво зависает,
                    {//либо оно не отображает смену картинок на рулетке
                        if (number > 8) number = 1;                    
                        roulette.Image = rouletteNumbers.Images[number - 1];
                        //поэтому я вспомнил тот пример с потоком, который Вы мне показали и сделал так
                        Thread.Sleep(10 + i * 2);                       
                    }
                    
                    IsThreadActive = false;//не знал как заблочить приложение, пока рулетка крутиться, решил
                });//использовать таймер и булевое свойство

                thread.Start();

                RouletteWheel(this, GetRouletteNumber(randomNumber));//Но так как поток считал бы число после того,
            }//как событие бы его уже разослало(и число на рулетке не совпадало с истинным числом), я сделал отдельный метод для расчета
        }

        private RouletteNumber GetRouletteNumber(int value)
        {
            RouletteNumber rouletteNumber = RouletteNumber.CreateRandomNumber();

            for (int i = 0, number = 1; i < value; i++, number++)
            {
                if (number > 8) number = 1;
                rouletteNumber.Number = number;
            }

            return rouletteNumber;
        }
    }
}
