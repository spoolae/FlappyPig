using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score;
    public int highscore;
    public int coins;

    public void Awake()
    {
        Instance = this;
    }

   void Start()
    {
        PlayerPrefs.SetInt("score", score);
        score = PlayerPrefs.GetInt("score", score);
        coins = PlayerPrefs.GetInt("coins", coins);
    }

    void Update()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        PlayerPrefs.SetInt("coins", coins);
    }

     public void WriteToHighScore()
    {
        if (score > PlayerPrefs.GetInt("highscore", highscore))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddCoins()
    {
        coins = coins + score * 2;
    }


}
