using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab1;
    public GameObject groundPrefab2;
    public GameObject groundPrefab3;
    public GameObject backgroundPrefab1;
    public GameObject backgroundPrefab2;
    public GameObject backgroundPrefab3;

    void Start()
    {
        spawnGround();
    }

    private void spawnGround()
    {
        switch (GameManager.Instance.groundPrefab)
        {
            case 0: GameObject a = Instantiate(groundPrefab1) as GameObject;
                    GameObject a1 = Instantiate(backgroundPrefab1) as GameObject; break;
            case 1: GameObject b = Instantiate(groundPrefab2) as GameObject;
                    GameObject b1 = Instantiate(backgroundPrefab2) as GameObject; break;
            case 2: GameObject c = Instantiate(groundPrefab3) as GameObject;
                    GameObject c1 = Instantiate(backgroundPrefab3) as GameObject; break;
            default: GameObject d = Instantiate(groundPrefab1) as GameObject;
                     GameObject d1 = Instantiate(backgroundPrefab1) as GameObject; break;
        }
    }
}
