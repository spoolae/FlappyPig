using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipesPrefab1;
    public GameObject pipesPrefab2;
    public GameObject pipesPrefab3;
    public float respawnTime = 1.0f;

    void Start()
    {
        StartCoroutine(Spawner());
      //  GameObject a = Instantiate(pipesPrefab) as GameObject;
    }

    private void spawnPipes()
    {
        switch (GameManager.Instance.pipesPrefab)
        {
            case 0: GameObject a = Instantiate(pipesPrefab1) as GameObject; break;
            case 1: GameObject b = Instantiate(pipesPrefab2) as GameObject; break;
            case 2: GameObject c = Instantiate(pipesPrefab3) as GameObject; break;
            default: GameObject d = Instantiate(pipesPrefab1) as GameObject; break;
        }
        
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            if (!GameManager.Instance.isDead && GameManager.Instance.isStart)
            {
                spawnPipes();
            }
        }
    }
}
