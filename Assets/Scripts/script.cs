using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject screamer;
    public float delay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        screamer.GetComponent<SpriteRenderer> ().color = new Color(1, 1, 1, 0);
    }
    public void PointerClick()
    {
        //screamer.SetActive(true);
       
       // StartCoroutine(FadeIn());
        StartCoroutine(FadeImage(true));
        
    }
   

     IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1f; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                screamer.GetComponent<SpriteRenderer> ().color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1f; i += Time.deltaTime)
            {
                // set color with i as alpha
                screamer.GetComponent<SpriteRenderer> ().color = new Color(1, 1, 1, i);
                yield return null;
            }
            
        }
        
    }
}
