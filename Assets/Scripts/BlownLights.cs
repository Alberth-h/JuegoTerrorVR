using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlownLights : MonoBehaviour
{
    [SerializeField] Light light;
    private float _elapsedTime = 0.0f;
    private float _blownTime = 0.25f;
    private float _lightWorkingTime;
    private float _maxLightIntensity = 12.0f;
    private float _minLightIntensity = 0.0f;
    private float _minlightWorkingTime = 0.5f;
    private float _maxlightWorkingTime = 2.0f;

    void Start()
    {
        _lightWorkingTime = Random.Range(_minlightWorkingTime, _maxlightWorkingTime);
    }
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= _lightWorkingTime) {
            _elapsedTime = 0;
            _lightWorkingTime = Random.Range(_minlightWorkingTime, _maxlightWorkingTime);
        }
        if(_elapsedTime < _lightWorkingTime - _blownTime) {
            light.intensity = _maxLightIntensity;
        }
        else
        {
            light.intensity = _minLightIntensity;
        }
    }
}
