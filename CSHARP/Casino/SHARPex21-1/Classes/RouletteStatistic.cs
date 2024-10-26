using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SHARPex21_1.Classes;

namespace SHARPex21_1.Forms
{
    [Serializable]
    public class RouletteStatistic
    {
        public int JoyCounter { get; private set; } = 0;
        public int Draws { get; private set; } = 0;
        public int PlayerWins { get; private set; } = 0;
        public int EnemyWins { get; private set; } = 0;
        public int PlayerLoses { get; private set; } = 0;
        public int EnemyLoses { get; private set; } = 0;
        public int MoneyWonByPlayer { get; private set; } = 0;
        public int MoneyWonByEnemy { get; private set; } = 0;
        public int MoneyLostByPlayer { get; private set; } = 0;
        public int MoneyLostByEnemy { get; private set; } = 0;

        public static RouletteStatistic FromFile(string wayToFile)
        {
            RouletteStatistic rouletteStatistic = new RouletteStatistic();

            if (File.Exists(wayToFile))
            {
                try
                {
                    using (Stream stream = File.OpenRead(wayToFile))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        rouletteStatistic = formatter.Deserialize(stream) as RouletteStatistic;
                    }

                    return rouletteStatistic;
                }
                catch
                {
                    MessageBoxBetterThanBasicMessageBox.Show("New statistics have been created", "Error");
                    return new RouletteStatistic();
                }
            }

            return rouletteStatistic;
        }

        public void Save(string wayToFile)
        {
            using (Stream stream = File.Create(wayToFile))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }

        public void UpdateStatistic(object sender, EventArgs eventArgs)
        {
            if(sender is CasinoManager)
            {
                if(eventArgs is BoxWithPoliteMessage)
                    Unpacking(eventArgs as BoxWithPoliteMessage);

                CasinoManager manager = sender as CasinoManager;

                if (manager.GetSomeBoolValuesForStatistic()[0] && manager.GetSomeBoolValuesForStatistic()[1])
                {
                    PlayerWins++;
                    EnemyWins++;
                    Draws++;
                }
                else if (manager.GetSomeBoolValuesForStatistic()[0])
                {
                    PlayerWins++;
                    EnemyLoses++;
                    MoneyWonByPlayer += manager.GetSomeNumberForStatistic() / 2;
                    MoneyLostByEnemy += manager.GetSomeNumberForStatistic() / 2;
                }
                else if (manager.GetSomeBoolValuesForStatistic()[1])
                {
                    EnemyWins++;
                    PlayerLoses++;
                    MoneyWonByEnemy += manager.GetSomeNumberForStatistic() / 2;
                    MoneyLostByPlayer += manager.GetSomeNumberForStatistic() / 2;
                }
                else
                {
                    EnemyLoses++;
                    PlayerLoses++;
                    MoneyLostByEnemy += manager.GetSomeNumberForStatistic() / 2;
                    MoneyLostByPlayer += manager.GetSomeNumberForStatistic() / 2;
                }
            }
        }

        private void Unpacking(BoxWithPoliteMessage box)
        {
            if (box.Message == "Hello, Mr. Statistic!")
                Rejoice();
        }

        private void Rejoice()
        {
            //радуется :)
            JoyCounter++; //повышаем счетчик радости
        }
    }
}
