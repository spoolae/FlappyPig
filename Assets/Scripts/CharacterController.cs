using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour

{

    public float force;
    private new Rigidbody2D rigidbody;
 //   public GameObject panel;
    public GameObject pigCharacter;
 //   public GameObject scoreDisplay;
    public GameObject deathPrefab;
    public GameObject deathEffect;
    public GameObject jumpAudio;
    public GameObject deathAudio;
    private float timer;

   // public bool isDead;

    void Awake()

    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
     //   isDead = false;
    }

    void Update()

    {
        if (!GameManager.Instance.isDead && !GameManager.Instance.isStart)
        {
            timer += Time.deltaTime;
            transform.localPosition = new Vector3(-2, (0.6f * Mathf.Sin(3.5f * timer)), 0);
            if (Input.GetMouseButtonDown(0))
            {
                GameManager.Instance.isStart = true;
            }
        }

            if (GameManager.Instance.isStart && !GameManager.Instance.isDead)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (PlayerPrefs.GetInt("isMute", 0) == 0)
                    {
                        GameObject j = Instantiate(jumpAudio, transform.position, Quaternion.identity) as GameObject;
                    }
                    rigidbody.gravityScale = 1.75f;
                    rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
                }
                rigidbody.MoveRotation(rigidbody.velocity.y * 2.75F);
                if (rigidbody.velocity.y < -1f)
                {           
                    rigidbody.gravityScale = 2.5f;
                }
            }
      
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (GameManager.Instance.isStart)
        {
            //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // panel.SetActive(true);
            // StartCoroutine("ActivePanel");
            GameObject a = Instantiate(deathPrefab, transform.position, Quaternion.identity) as GameObject;
            GameObject e = Instantiate(deathEffect, transform.position, Quaternion.identity) as GameObject;
            ScoreManager.Instance.WriteToHighScore();
            ScoreManager.Instance.AddCoins();
            pigCharacter.SetActive(false);
            // scoreDisplay.SetActive(false);
            if (PlayerPrefs.GetInt("isMute", 0) == 0)
            {
                GameObject j = Instantiate(deathAudio, transform.position, Quaternion.identity) as GameObject;
            }
            GameManager.Instance.isDead = true;
            //Time.timeScale = 0;
        }
    }

}