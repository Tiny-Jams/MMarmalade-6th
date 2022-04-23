using UnityEngine;

namespace DefaultNamespace
{
    public class ScoreManager : MonoBehaviour
    {
        private static float HIGHSCORE = 0.0f;
        private static float SCORE = 0.0f;

        public static float Score
        {
            get => SCORE;
            set
            {
                if (HighScore < value)
                {
                    HighScore = value;
                }

                SCORE = value;
            }
        }

        public static float HighScore
        {
            get => HIGHSCORE;
            private set => HIGHSCORE = value;
        }
    }
}