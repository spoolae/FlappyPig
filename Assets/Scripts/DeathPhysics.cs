using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPhysics : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Start()
    {
        Vector2 position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
