using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemPipe : MonoBehaviour
{
   // public bool isBought, isSelected;
    public GameObject price;
    public GameObject iconLocked;
    public GameObject iconSelected;
    public int PipeIndex;

    void Update()
    {
        if (PlayerPrefs.GetInt("Pipe" + PipeIndex.ToString(), 0) == 1)
        {
            price.SetActive(false);
            iconLocked.SetActive(false);
            if (PlayerPrefs.GetInt("pipesPrefab", 0) == PipeIndex)
            {
                iconSelected.SetActive(true);
            }
            else
            {
                iconSelected.SetActive(false);
            }
        }
        else
        {
            price.SetActive(true);
            iconLocked.SetActive(true);
            iconSelected.SetActive(false);
        }
    }
}
