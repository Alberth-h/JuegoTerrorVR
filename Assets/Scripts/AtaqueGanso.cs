using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueGanso : MonoBehaviour
{
    public Vision vision;
    [SerializeField] string animation_name;
    private float _elapsedTimeVision = 0.0f;
    private float _elapsedTime = 0.0f;
    [SerializeField] float _anim_time;
    [SerializeField] float maxDuration;

    [SerializeField] float speed;

    [SerializeField] AudioClip sonido;
    [SerializeField] AudioSource audioSource {get{return GetComponent<AudioSource>();}}

    [SerializeField] GameObject cuadro;
    void Update()
    {
        Animation();
    }
    void Animation()
    {
        if(vision.canSeeEnemy && !cuadro.activeInHierarchy)
        {
            _elapsedTimeVision += Time.deltaTime;
            if(_elapsedTimeVision >= _anim_time) {
                Destroy(gameObject);
            }
            if(!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(sonido);
            }
            gameObject.GetComponent<Animator>().Play(animation_name);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
