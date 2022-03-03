using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsDisplay : MonoBehaviour
{
    public Text coinsDisplay;

    void Update()
    {   
        coinsDisplay.text = ScoreManager.Instance.coins.ToString();
    }
}
