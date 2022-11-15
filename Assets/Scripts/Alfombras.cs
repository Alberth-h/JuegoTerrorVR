using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alfombras : MonoBehaviour
{
    private Material renderer;
    public GameObject player;
    public GameObject TeleportTo;
    public float offsetTP = 1.50f;
    public float horizontaloffsetTP;
    private Color _emissionColorValue;
    private float _intensity;

    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>().material;
        _intensity = 0.25f;
        renderer.SetVector("_EmissionColor", Color.red * _intensity);
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        _intensity = 0.8f;
        renderer.SetVector("_EmissionColor", Color.white * _intensity);
       // renderer.material.color = Color.red;
        //player.transform.position = (new Vector3(TeleportTo.transform.position.x + horizontaloffsetTP, TeleportTo.transform.position.y + offsetTP , TeleportTo.transform.position.z));;
    }

    public void PointerClick()
    {
        player.transform.position = (new Vector3(TeleportTo.transform.position.x + horizontaloffsetTP, TeleportTo.transform.position.y + offsetTP , TeleportTo.transform.position.z));;

    }

    public void OnEnxit()
    {
        //renderer.material.color = Color.white;
        _intensity = 0.4f;
        renderer.SetVector("_EmissionColor", Color.red * _intensity);
    }
}
