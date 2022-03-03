using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text score;
    public ScoreManager sm;
    public GameObject pigCharacter;
    public GameObject panel;
    public GameObject scoreDisplay;

    void Start()
    {
        //score.text = ("Your score is ") + sm.score.ToString();
    }

    void Update()
    {
        if (GameManager.Instance.isStart && GameManager.Instance.isDead)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                scoreDisplay.SetActive(false);
                RestartScene();
            }
        }
        if (GameManager.Instance.isDead && GameManager.Instance.isStart)
        {
            StartCoroutine("ActivePanel");
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //pigCharacter.SetActive(true);
    }

    IEnumerator ActivePanel()
    {
        yield return new WaitForSeconds(1f);
        panel.SetActive(true); //yield return new WaitForSeconds(2f);
    }
}