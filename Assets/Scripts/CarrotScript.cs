using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotScript : MonoBehaviour
{
    public GameObject Carrot;
    public SpriteRenderer spriteToFade;
    private float timer = 10;

   /* void Start() 
    {
        rend = GetComponent<SpriteRenderer>();
    }
    */
    void Update()
    {
        if (!GameManager.Instance.isDead && !GameManager.Instance.isStart)
        {
            timer += Time.deltaTime;
            transform.localPosition = new Vector3(2.65f, (0.6f * Mathf.Sin(3.5f * timer))+0.75f, 0);
        }
        
        if (!GameManager.Instance.isDead && GameManager.Instance.isStart)
        {
            StartCoroutine(FadeOut(spriteToFade, 1f));
            StartCoroutine(DestroyCarrot(1f));
        }
    }

    IEnumerator FadeOut(SpriteRenderer MyRenderer, float duration)
    {
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }
    }

    IEnumerator DestroyCarrot(float a)
    {
        yield return new WaitForSeconds(a);
        if (!GameManager.Instance.isDead)
        {
            Destroy(gameObject);
        }
    }

}
