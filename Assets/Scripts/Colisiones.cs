using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using SpeechLib;

public class Colisiones : MonoBehaviour
{
    public GameObject puntuaciones;
    private int puntos = 0;
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    public AudioClip clip;
    public GameObject panel;

    private SpVoice voice;

    public static string finaltext="";
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        voice=new SpVoice();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider objeto)
    {
        voice.Volume = 100;
        voice.Rate = 0;
        if(objeto.gameObject.tag == "Moneda")
        {
            Debug.Log("Toco la moneda");
            Destroy(objeto.gameObject);
            audioSource.PlayOneShot(clip);
            puntos++;
            puntuaciones.GetComponent<Text>().text = puntos.ToString();
        }
        if(objeto.gameObject.tag == "CajaSigno")
        {
            panel.gameObject.SetActive(true);
            voice.Speak("Ma, ma, marrrano   Estoy ansioso de verásDe llegar pronto a su casaPara sacarme la vergaY que me de unas mamadasY antes de que se de cuentaVoy a venirme en su caraLe tomaré por sorpresaLe mamaré su burritoLe arrancaré con los dientesTres, tal vez cuatro pelitosLa voltearé con gran fuerzaY se lo haré de perritoMe ha pasado alguna vezQue hasta la he echo llorarPero me encanta meterlaY se tiene que aguantarAl fin y al cabo le gustaLa he escuchado murmurarQue si ella pierde mi vergaNo quedará que mamarMa, ma, marranoYo soy el ansiosoDe mamarte todo el osoDe chiquitearte el chiclosoQue importa si está apestosoYo soy el ansiosoPondré mi verga en sus tetasPara una puñeta rusaTal vez de pura mamadaPongo en su cara en mi trusaY eso nomás pa hostigarlaPorque sé que no le gustaDaré un pellizco que duelaVoy a morderle la espaldaLa meteré por el culoAunque me salga con cacaLe dejaré por completoTodas agüadas las nalgasDe su sala a la cocinaY hasta en el cuarto de atrásTambién en su lavadoraY en la mesa de billarVoy a dejarsela ir todaPues traigo fuerzas de másY si entre más, más se quejaMás se la voy a atascar", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }
    }
}
