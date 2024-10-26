using System;

namespace TwentyFortyEight.Model
{
    class TwentyFortyEightGame
    {
        private Random _random;

        public Tile[,] PlayingField { get; set; }

        private TwentyFortyEightGame()
        {
            PlayingField = new Tile[4, 4];
            _random = new Random();

            PlayingField[_random.Next(0, 4), _random.Next(0, 4)] = Tile.Create();
        }

        public static TwentyFortyEightGame Create() => new TwentyFortyEightGame();

        /// <summary>
        /// Сдвигает плитки вверх.
        /// </summary>
        /// <returns>Выполняет метод CheckingMoves()</returns>
        public bool Up()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if(PlayingField[k, i] != null)
                    {
                        bool isExist = true;

                        for (int j = k + 1; j < 4 && isExist; j++)
                            if(PlayingField[j, i] != null)
                            {
                                if(PlayingField[j, i].Denomination == PlayingField[k, i].Denomination)
                                {
                                    PlayingField[k, i] = Tile.Create((TileDenomination)(2 * (int)PlayingField[j, i].Denomination));
                                    PlayingField[j, i] = null;
                                }

                                isExist = false;
                            }
                    }

            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if (PlayingField[k, i] == null)
                        for (int j = k + 1; j < 4; j++)
                        {
                            bool isFind = false;

                            if (PlayingField[j, i] != null)
                            {
                                PlayingField[k, i] = PlayingField[j, i];
                                PlayingField[j, i] = null;

                                isFind = true;
                            }

                            if (isFind)
                                break;
                        }
           
            return CheckingMoves();
        }

        /// <summary>
        /// Сдвигает плитки вниз.
        /// </summary>
        /// <returns>Выполняет метод CheckingMoves()</returns>
        public bool Down()
        {
            for (int i = 3; i >= 0; i--)
                for (int k = 3; k >= 0; k--)
                    if (PlayingField[k, i] != null)
                    {
                        bool isExist = true;

                        for (int j = k - 1; j >= 0 && isExist; j--)
                            if (PlayingField[j, i] != null)
                            {
                                if (PlayingField[j, i].Denomination == PlayingField[k, i].Denomination)
                                {
                                    PlayingField[k, i] = Tile.Create((TileDenomination)(2 * (int)PlayingField[j, i].Denomination));
                                    PlayingField[j, i] = null;
                                }

                                isExist = false;
                            }
                    }

            for (int i = 0; i < 4; i++)
                for (int k = 3; k >= 0; k--)
                    if (PlayingField[k, i] == null)
                        for (int j = k - 1; j >= 0; j--)
                        {
                            bool isFind = false;

                            if (PlayingField[j, i] != null)
                            {
                                PlayingField[k, i] = PlayingField[j, i];
                                PlayingField[j, i] = null;

                                isFind = true;
                            }

                            if (isFind)
                                break;
                        }

            return CheckingMoves();
        }

        /// <summary>
        /// Сдвигает плитки влево.
        /// </summary>
        /// <returns>Выполняет метод CheckingMoves()</returns>
        public bool Left()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if (PlayingField[i, k] != null)
                    {
                        bool isExist = true;

                        for (int j = k + 1; j < 4 && isExist; j++)
                            if (PlayingField[i, j] != null)
                            {
                                if (PlayingField[i, j].Denomination == PlayingField[i, k].Denomination)
                                {
                                    PlayingField[i, k] = Tile.Create((TileDenomination)(2 * (int)PlayingField[i, j].Denomination));
                                    PlayingField[i, j] = null;
                                }

                                isExist = false;
                            }
                    }

            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if (PlayingField[i, k] == null)
                        for (int j = k + 1; j < 4; j++)
                        {
                            bool isFind = false;

                            if (PlayingField[i, j] != null)
                            {
                                PlayingField[i, k] = PlayingField[i, j];
                                PlayingField[i, j] = null;

                                isFind = true;
                            }

                            if (isFind)
                                break;
                        }

            return CheckingMoves();
        }

        /// <summary>
        /// Сдвигает плитки вправо.
        /// </summary>
        /// <returns>Выполняет метод CheckingMoves()</returns>
        public bool Right()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 3; k >= 0; k--)
                    if (PlayingField[i, k] != null)
                    {
                        bool isExist = true;

                        for (int j = k - 1; j >= 0 && isExist; j--)
                            if (PlayingField[i, j] != null)
                            {
                                if (PlayingField[i, j].Denomination == PlayingField[i, k].Denomination)
                                {
                                    PlayingField[i, k] = Tile.Create((TileDenomination)(2 * (int)PlayingField[i, j].Denomination));
                                    PlayingField[i, j] = null;
                                }

                                isExist = false;
                            }
                    }

            for (int i = 0; i < 4; i++)
                for (int k = 3; k >= 0; k--)
                    if (PlayingField[i, k] == null)
                        for (int j = k - 1; j >= 0; j--)
                        {
                            bool isFind = false;

                            if (PlayingField[i, j] != null)
                            {
                                PlayingField[i, k] = PlayingField[i, j];
                                PlayingField[i, j] = null;

                                isFind = true;
                            }

                            if (isFind)
                                break;
                        }

            return CheckingMoves();
        }

        /// <summary>
        /// Проверяет выиграна ли игра.
        /// </summary>
        /// <returns>true - игра выиграна. false - игра проиграна.</returns>
        public bool CheckWin()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if (PlayingField[i, k] != null)
                        if (PlayingField[i, k].Denomination == TileDenomination.TwentyFortyEight)
                            return true;

            return false;
        }

        /// <summary>
        /// Проверяет возможен ли ход. Если невозможен, проверит выиграна ли игра. Следует вызывать метод CheckWin() после этого метода.
        /// </summary>
        /// <returns>true - ход возможен(или игра выиграна). false - ход невозможен</returns>
        private bool CheckingMoves()
        {
            if (!SpawnTile())
            {
                for (int i = 0; i < 4; i++)
                    for (int k = 0; k < 4; k++)
                    {
                        if (i - 1 >= 0)
                            if (PlayingField[i, k].Denomination == PlayingField[i - 1, k].Denomination)
                                return true;

                        if(i + 1 <= 3)
                            if (PlayingField[i, k].Denomination == PlayingField[i + 1, k].Denomination)
                                return true;

                        if (k + 1 <= 3)
                            if (PlayingField[i, k].Denomination == PlayingField[i, k + 1].Denomination)
                                return true;

                        if (k - 1 >= 0)
                            if (PlayingField[i, k].Denomination == PlayingField[i, k - 1].Denomination)
                                return true;
                    }

                return CheckWin();
            }

            return true;
        } 

        /// <summary>
        /// Генерирует на игровом поле объект класса Tile, если это возможно
        /// </summary>
        /// <returns>true - успешно сгенерирована. false - не удалось сгенерировать</returns>
        private bool SpawnTile()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    if (PlayingField[i, k] == null)
                    {
                        bool isSuccess = false;
                        int x, y;

                        while (!isSuccess)
                        {
                            if (PlayingField[x = _random.Next(0, 4), y = _random.Next(0, 4)] == null)
                            {
                                PlayingField[x, y] = Tile.Create();
                                isSuccess = true;
                            }

                        }

                        return true;
                    }

            return false;
        }
    }
}
