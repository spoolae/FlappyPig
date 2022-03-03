using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    public Text highScoreDisplay;
    public Text coinsUpDisplay;
    int c;

    void Start()
    {
       // highScoreDisplay.text = ScoreManager.Instance.highscore.ToString();
    }

    void Update()
    {
        highScoreDisplay.text = ScoreManager.Instance.highscore.ToString();
        c = ScoreManager.Instance.score * 2;
        coinsUpDisplay.text = c.ToString();
    }
}
