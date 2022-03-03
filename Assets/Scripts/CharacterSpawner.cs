using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject characterPrefab1;
    public GameObject characterPrefab2;
    public GameObject characterPrefab3;

    void Start()
    {
        spawnGround();
    }

    private void spawnGround()
    {
        switch (GameManager.Instance.characterPrefab)
        {
            case 0: GameObject a = Instantiate(characterPrefab1) as GameObject; break;
            case 1: GameObject b = Instantiate(characterPrefab2) as GameObject; break;
            case 2: GameObject c = Instantiate(characterPrefab3) as GameObject; break;
            default: GameObject d = Instantiate(characterPrefab1) as GameObject; break;
        }
    }
}
