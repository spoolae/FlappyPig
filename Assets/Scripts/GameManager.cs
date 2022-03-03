using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isDead, isStart;
    public int pipesPrefab, characterPrefab, groundPrefab;
    public int price;

    public void Awake()
    {   
        Instance = this;
    }

    void Start()
    { 
        //PlayerPrefs.DeleteAll();
        pipesPrefab = PlayerPrefs.GetInt("pipesPrefab", pipesPrefab);
        PlayerPrefs.SetInt("Pipe0", 1);
        characterPrefab = PlayerPrefs.GetInt("characterPrefab", characterPrefab);
        PlayerPrefs.SetInt("Character0", 1);
        groundPrefab = PlayerPrefs.GetInt("groundPrefab", groundPrefab);
        PlayerPrefs.SetInt("Ground0", 1);

    }
    public void LoadScene(int Index)
    {
        SceneManager.LoadScene(Index);
    }
    /*
    private void spawnCharacter()
    {
        switch (GameManager.Instance.pipesPrefab)
        {
            case 0: GameObject a = Instantiate(characterPrefab1) as GameObject; break;
            case 1: GameObject b = Instantiate(characterPrefab2) as GameObject; break;
            case 2: GameObject c = Instantiate(characterPrefab3) as GameObject; break;
            default: GameObject d = Instantiate(characterPrefab1) as GameObject; break;
        }
    }*/

    public void SelectPipesPrefab(int a)
    {
        if (PlayerPrefs.GetInt("Pipe"+a.ToString(), 0) == 1)
        {
            PlayerPrefs.SetInt("pipesPrefab", a);
        }
    }

    public void SelectCharacterPrefab(int a)
    {
        if (PlayerPrefs.GetInt("Character" + a.ToString(), 0) == 1)
        {
            PlayerPrefs.SetInt("characterPrefab", a);
        }
    }

    public void SelectGroundPrefab(int a)
    {
        if (PlayerPrefs.GetInt("Ground" + a.ToString(), 0) == 1)
        {
            PlayerPrefs.SetInt("groundPrefab", a);
        }
    }

    public void SetPrice(int p)
    {
        price = p;
    }

    public void BuyPipesPrefab(int a)
    {  
        if(price <= ScoreManager.Instance.coins && PlayerPrefs.GetInt("Pipe" + a.ToString(), 0) == 0)
        {
            PlayerPrefs.SetInt("Pipe" + a.ToString(), 1);
            PlayerPrefs.SetInt("pipesPrefab", a);
            ScoreManager.Instance.coins -= price;
        }
    }

    public void BuyCharacterPrefab(int a)
    {
        if (price <= ScoreManager.Instance.coins && PlayerPrefs.GetInt("Character" + a.ToString(), 0) == 0)
        {
            PlayerPrefs.SetInt("Character" + a.ToString(), 1);
            PlayerPrefs.SetInt("characterPrefab", a);
            ScoreManager.Instance.coins -= price;
        }
    }

    public void BuyGroundPrefab(int a)
    {
        if (price <= ScoreManager.Instance.coins && PlayerPrefs.GetInt("Ground" + a.ToString(), 0) == 0)
        {
            PlayerPrefs.SetInt("Ground" + a.ToString(), 1);
            PlayerPrefs.SetInt("groundPrefab", a);
            ScoreManager.Instance.coins -= price;
        }
    }

    public void AddCoins()
    {
        ScoreManager.Instance.coins += 300;
    }
}
