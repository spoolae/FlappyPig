using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] Image buttonOn;
    [SerializeField] Image buttonOff;

    void Start()
    {
        if (PlayerPrefs.GetInt("isMute", 0) == 1)
        {
            buttonOn.enabled = false;
            buttonOff.enabled = true;
        }
        else
        {
            buttonOn.enabled = true;
            buttonOff.enabled = false;
        }

    }

    public void SoundButtOn()
    {       
        if (PlayerPrefs.GetInt("isMute", 0) == 1)
        {
            PlayerPrefs.SetInt("isMute", 0);
            buttonOn.enabled = true;
            buttonOff.enabled = false;
        }
        else
        {
            PlayerPrefs.SetInt("isMute", 1);
            buttonOn.enabled = false;
            buttonOff.enabled = true;
        }
    }
}
