using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPanelScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject scoreDisplay;

    void Update()
    {
     if (GameManager.Instance.isDead == true)
        {
            scoreDisplay.SetActive(false);
        }
    }
 
}
