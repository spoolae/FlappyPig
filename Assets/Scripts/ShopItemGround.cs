using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemGround : MonoBehaviour
{
    // public bool isBought, isSelected;
    public GameObject price;
    public GameObject iconLocked;
    public GameObject iconSelected;
    public int GroundIndex;

    void Update()
    {
        if (PlayerPrefs.GetInt("Ground" + GroundIndex.ToString(), 0) == 1)
        {
            price.SetActive(false);
            iconLocked.SetActive(false);
            if (PlayerPrefs.GetInt("groundPrefab", 0) == GroundIndex)
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
