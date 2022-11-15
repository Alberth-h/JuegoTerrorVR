using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Vision vision;
    [SerializeField] string animation_name;
    private float _elapsedTime = 0.0f;
    [SerializeField] float _anim_time;

    [SerializeField] float speed;

    [SerializeField] AudioClip sonido;
    [SerializeField] AudioSource audioSource {get{return GetComponent<AudioSource>();}}

    void Update()
    {
        Animation();
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= _anim_time) {
            Destroy(gameObject);
        }
    }
    void Animation()
    {
        if(vision.canSeeEnemy)
        {
            gameObject.GetComponent<Animator>().Play(animation_name);
            audioSource.PlayOneShot(sonido);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    
}
