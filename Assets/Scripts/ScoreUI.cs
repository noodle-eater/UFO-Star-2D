using UnityEngine;
using UnityEngine.UI;

namespace NoodleEater
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private Text scoreText;

        public void SetScore(int score)
        {
            scoreText.text = score.ToString();
        }
    }
}