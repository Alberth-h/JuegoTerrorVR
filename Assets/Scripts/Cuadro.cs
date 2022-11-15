using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpeechLib;
public class Cuadro : MonoBehaviour
{
    //private Renderer renderer;
    [SerializeField] GameObject panel;
    [SerializeField] float offsetY;
    [SerializeField] AudioClip ganso;
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    private SpVoice voice;
    private Material renderer;
    private Color _emissionColorValue;
    private float _intensity;

    public Puntuacion puntuacion;
    [SerializeField] GameObject puntuaciones;

    [SerializeField] GameObject enemy;

    
    void Start()
    {
        renderer = this.GetComponent<Renderer>().material;
        _intensity = 0f;
        renderer.SetVector("_EmissionColor", Color.white * _intensity);
        gameObject.AddComponent<AudioSource>();
        voice=new SpVoice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        
        //renderer.material.color = Color.red;
        voice.Volume = 100;
        voice.Rate = 0;
        
        if(this.gameObject.tag == "ganso")
        {
            audioSource.PlayOneShot(ganso);
            panel.gameObject.SetActive(true);
            voice.Speak("You will die", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            //dialogo.GetComponent<Text>().text = voice.ToString();
        }    }
  
    public void OnEnxit()
    {
       if(this.gameObject.tag == "ganso"){
             panel.gameObject.SetActive(false);
             voice.Speak("ADIOS AMIGO HOMO", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            voice.Volume = 0;
        } 
    }

    public void OnEnterPicture()
    {
        //gameObject.GetComponent<AudioSource>().PlayOneShot(soundBanana, 0.7f);
        _intensity = 1f;
        renderer.SetVector("_EmissionColor", Color.red * _intensity);
    }

    public void ClickOnCuadro()
    {
        puntuacion.puntos++;
		puntuaciones.GetComponent<Text>().text="Cuadros: " + puntuacion.puntos.ToString() + "/" + "5";

        gameObject.SetActive(false);
        enemy.SetActive(true);
    }

    public void OnEnxitPicture()
    {
        _intensity = 0f;
        renderer.SetVector("_EmissionColor", Color.white * _intensity);
    }
}
