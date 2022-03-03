using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesBehaviour : MonoBehaviour

{

    [SerializeField]
    private float speed;
    public float minPos;
    public float maxPos;

    void Start()

    {

        Vector2 position = transform.position;

        position.y = Random.Range(minPos, maxPos);

        transform.position = position;


        StartCoroutine(DestroyPipe());
        
    }

    void Update()

    {
        if (!GameManager.Instance.isDead)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
        }
    }

    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }

    IEnumerator DestroyPipe()
    {
        yield return new WaitForSeconds(6f);
        if (!GameManager.Instance.isDead)
        {
            Destroy(gameObject);
        }
    }
}