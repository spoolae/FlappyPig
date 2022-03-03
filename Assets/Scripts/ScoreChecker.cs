using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{
    public GameObject scoreUpAudio;
    bool isReady = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isReady)
        {
            StartCoroutine(ScoreUp(other));
            isReady = false;
        }
    }

    IEnumerator ScoreUp(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            ScoreManager.Instance.score++;        
            if (PlayerPrefs.GetInt("isMute", 0) == 0)
            {
                GameObject j = Instantiate(scoreUpAudio, transform.position, Quaternion.identity) as GameObject;
            }
        }
        yield return new WaitForSeconds(0.1f);
        isReady = true;
    }
}
