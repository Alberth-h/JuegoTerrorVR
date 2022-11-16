using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject cuadrofinal;
    private float _elapsedTime = 0.0f;
    void Update()
    {
        if(cuadrofinal.activeInHierarchy == false)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime > 1.1)
            {
                SceneManager.LoadScene("End");
            }
        }   
    }
}
