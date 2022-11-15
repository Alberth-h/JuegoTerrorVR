using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    public void OnEnter(){
        audioSource.PlayOneShot(clip);
    }
}
