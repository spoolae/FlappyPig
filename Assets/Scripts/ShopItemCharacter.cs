using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemCharacter : MonoBehaviour
{
    // public bool isBought, isSelected;
    public GameObject price;
    public GameObject iconLocked;
    public GameObject iconSelected;
    public int CharacterIndex;

    void Update()
    {
        if (PlayerPrefs.GetInt("Character" + CharacterIndex.ToString(), 0) == 1)
        {
            price.SetActive(false);
            iconLocked.SetActive(false);
            if (PlayerPrefs.GetInt("characterPrefab", 0) == CharacterIndex)
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
