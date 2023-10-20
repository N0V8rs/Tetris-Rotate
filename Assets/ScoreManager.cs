using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class TetrisBlock : MonoBehaviour
    {
        public Text scoreText;
        private int score = 0;

        void Start()
        {
            // Initialize the score text
            UpdateScoreUI();
        }

        void UpdateScoreUI()
        {
            scoreText.text = "Score: " + score.ToString();
        }

        void CheckLines()
        {
            // Logic to check and clear lines goes here
            // ...

            // Assuming 'linesCleared' is the number of lines cleared
            int linesCleared = 1; // Example value, replace this with your actual logic

            if (linesCleared > 0)
            {
                // Increase the score based on the number of lines cleared
                score += linesCleared * 100; // Award 100 points per cleared line
                UpdateScoreUI();
            }
        }
    }
}