using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    public void CambiarAnim()
    {
         anim.Play("anim2");
    }
    void Update()
    {
    }
}
