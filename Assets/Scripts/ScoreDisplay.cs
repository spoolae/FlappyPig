using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreDisplay;
    public string addText;

    void Update()
    {
        scoreDisplay.text = addText.ToString() + ScoreManager.Instance.score.ToString();
    }
}
