using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_4_act : MonoBehaviour
{
    Pr3_4_not notificador;
    int puntos = 0;

    void Start()
    {
        notificador = GameObject.Find("CubeG").GetComponent<Pr3_4_not>();
        notificador.onEventCollection += SumarPuntos;
    }

    void SumarPuntos(int puntos)
    {
        this.puntos += puntos;
        Debug.Log("Puntos: " + this.puntos);
    }
}
