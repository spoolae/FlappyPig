using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPrefabBehaviour : MonoBehaviour
{
    void Start()
    {
        DestroyAudio();
    }

    IEnumerator DestroyAudio()
    {
        yield return new WaitForSeconds(4f);
        if (!GameManager.Instance.isDead)
        {
            Destroy(gameObject);
        }
    }
}
