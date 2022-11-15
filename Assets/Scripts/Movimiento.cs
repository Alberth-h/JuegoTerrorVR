using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpeechLib;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    float m_speed = 2.0f;
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    public AudioClip clip;

    public GameObject panel;

    private SpVoice voice;
    public static string finaltext="";
    //public GameObject dialogo;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        voice=new SpVoice();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) //frente
        {
            this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) //atras
        {
            this.transform.Translate(Vector3.back * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //izquierda
        {
            this.transform.Translate(Vector3.left * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //derecha
        {
            this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
        } 
    }

     void OnTriggerEnter(Collider objeto)
    {
        voice.Volume = 100;
        voice.Rate = 0;
        
        if(objeto.gameObject.tag == "Caja")
        {
            audioSource.PlayOneShot(clip);
            panel.gameObject.SetActive(true);
            voice.Speak("Arremangala Arrepujala Si, arremangala arrepujala no, Ma, ma, marrrano   Estoy ansioso de verásDe llegar pronto a su casaPara sacarme la vergaY que me de unas mamadasY antes de que se de cuentaVoy a venirme en su caraLe tomaré por sorpresaLe mamaré su burritoLe arrancaré con los dientesTres, tal vez cuatro pelitosLa voltearé con gran fuerzaY se lo haré de perritoMe ha pasado alguna vezQue hasta la he echo llorarPero me encanta meterlaY se tiene que aguantarAl fin y al cabo le gustaLa he escuchado murmurarQue si ella pierde mi vergaNo quedará que mamarMa, ma, marranoYo soy el ansiosoDe mamarte todo el osoDe chiquitearte el chiclosoQue importa si está apestosoYo soy el ansiosoPondré mi verga en sus tetasPara una puñeta rusaTal vez de pura mamadaPongo en su cara en mi trusaY eso nomás pa hostigarlaPorque sé que no le gustaDaré un pellizco que duelaVoy a morderle la espaldaLa meteré por el culoAunque me salga con cacaLe dejaré por completoTodas agüadas las nalgasDe su sala a la cocinaY hasta en el cuarto de atrásTambién en su lavadoraY en la mesa de billarVoy a dejarsela ir todaPues traigo fuerzas de másY si entre más, más se quejaMás se la voy a atascar", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            //dialogo.GetComponent<Text>().text = voice.ToString();
        }
    }
    void OnTriggerExit(Collider objeto) {
        if(objeto.gameObject.tag == "Caja"){
             panel.gameObject.SetActive(false);
             voice.Speak("ADIOS AMIGO HOMO", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            voice.Volume = 0;
        }
       
    }
}