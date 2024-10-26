using System;

namespace TwentyFortyEight.Model
{
    class ScoreEventArgs : EventArgs
    {
        public int Score { get; private set; }

        private ScoreEventArgs(int Score) =>
            this.Score = Score;

        public static ScoreEventArgs Create(int score) => new ScoreEventArgs(score);
    }
}
