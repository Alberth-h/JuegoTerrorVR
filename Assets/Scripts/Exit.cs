using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    public AudioClip clip;
    
    public Image panel;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnter()
    {
        audioSource.PlayOneShot(clip);
        panel.color = UnityEngine.Color.red;
    }

    public void PointerClick()
    {
        Application.Quit();
    }

    public void OnExit()
    {
        panel.color = UnityEngine.Color.black;
    }
}
