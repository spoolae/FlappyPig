using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetReadyScript : MonoBehaviour
{
    private float timer = 10;
    public Text textToFade;
    /* void Start() 
     {
         rend = GetComponent<SpriteRenderer>();
     }
     */
    void Update()
    {
        if (!GameManager.Instance.isDead && GameManager.Instance.isStart)
        {
            //textToFade.color = 1;
            StartCoroutine(FadeOut(textToFade, 1f));
            StartCoroutine(DestroyGetReady(1f));
        }
    }
    
    IEnumerator FadeOut(Text MyRenderer, float duration)
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

    
    IEnumerator DestroyGetReady(float a)
    {
        yield return new WaitForSeconds(a);
        if (!GameManager.Instance.isDead)
        {
            Destroy(gameObject);
        }
    }

}
