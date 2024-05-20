using System;
using Hero;
using PipeLogic;
using TMPro;
using UnityEngine;

namespace Services
{
    public class GameManager : MonoBehaviour
    {
        public FlyBehavior _fly;
        
        public TMP_Text scoreText;
        public TMP_Text maxScore;
        public GameObject playButton;
        public GameObject gameOver;

        public TMP_Text maxScoreDisplay;
        
        private static int scoreCount;
        private static int MaxScoreCount;
        
        

        private void Awake()
        {
            Application.targetFrameRate = 60;
            
            Pause();

        }

        private void Start()
        {
            if (PlayerPrefs.HasKey("HighScore")) 
                MaxScoreCount = PlayerPrefs.GetInt("HighScore");
        }

        private void Update()
        {
            if (scoreCount > MaxScoreCount) 
                MaxScoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", MaxScoreCount);

            maxScore.text = "HighScore:" + MaxScoreCount;
            
        }

        public void Play()
        {
            scoreCount = 0;
            scoreText.text = scoreCount.ToString();

            playButton.SetActive(false);
            gameOver.SetActive(false);
            maxScore.gameObject.SetActive(false);

            Time.timeScale = 1f;
            _fly.enabled = true;

            Pipes[] pipes = FindObjectsOfType<Pipes>();

            for (int i = 0; i < pipes.Length; i++)
            {
                Destroy(pipes[i].gameObject);
            }
        }

        private void Pause()
        {
            Time.timeScale = 0f;
            _fly.enabled = false;
        }

        public void GameOver()
        {
            
            maxScoreDisplay.gameObject.SetActive(true);
            maxScoreDisplay.text = "Max score: " + MaxScoreCount;
            
            gameOver.gameObject.SetActive(true);
            playButton.SetActive(true);
            
            
            Pause();
        }

        public void IncreaseScore()
        {
            scoreCount++;
            scoreText.text = scoreCount.ToString();
        }
    }
}
