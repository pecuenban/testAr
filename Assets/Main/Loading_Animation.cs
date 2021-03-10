using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading_Animation : MonoBehaviour
{
    float m_Speed;
    
    //Tiempo del temporizador 
    float targetTime = 5.0f;

    void Start()
    {
        //Velocidad de la rotacion
        m_Speed = 38.0f;
        transform.Rotate(60, 0, 60);
    }

    void Update()
    {
        //Rotacion del objeto
        transform.Rotate(Vector3.up * m_Speed * Time.deltaTime, Space.Self);

        //Temporizador para cambio de escena
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f){
            timerEnded();
        }
    }
    void timerEnded(){
        SceneManager.LoadScene("Realidad_Aumentada");
    }
}