using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titubeo : MonoBehaviour
{
    private float _elapsedTime = 0.0f;
    private float _desaparicionTime = 1.5f;
    private float _aparicionTime;
    private float _minAparcionTime = 2.5f;
    private float _maxAparcionTime = 5.0f;
    [SerializeField] Material material;

    void Start()
    {
        _aparicionTime = Random.Range(_minAparcionTime, _minAparcionTime);
    }

    // Update is called once per frame
    void Update()
    {
        Color color = material.color;
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= _aparicionTime) {
            _elapsedTime = 0;
            _aparicionTime = Random.Range(_minAparcionTime, _minAparcionTime);
        }
        if(_elapsedTime < _aparicionTime - _desaparicionTime) {
            color.a = 0.6f;
            material.color = color;
        }
        else
        {
            color.a = 0.0f;
            material.color = color;
        }
    }
}
