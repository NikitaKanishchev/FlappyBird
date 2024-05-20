using TMPro;
using UnityEngine;

public class Load : MonoBehaviour
{
    public TMP_Text maxScore;
    
    private static int MaxScoreCount;
    
    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore")) 
            MaxScoreCount = PlayerPrefs.GetInt("HighScore");
    }

    private void Update()
    {
        PlayerPrefs.SetInt("HighScore", MaxScoreCount);

        maxScore.text = "HighScore:" + MaxScoreCount;
    }
}
