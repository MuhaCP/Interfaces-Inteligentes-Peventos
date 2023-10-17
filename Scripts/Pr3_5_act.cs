using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pr3_5_act : MonoBehaviour
{   
    TextMeshProUGUI textMesh;

    Pr3_4_not notificador;

    int puntos = 0;

    void Start()
    {   
        textMesh = GameObject.Find("Canvas/Text").GetComponent<TextMeshProUGUI>();
        Debug.Log(textMesh);
        notificador = GameObject.Find("CubeG").GetComponent<Pr3_4_not>();
        notificador.onEventCollection += SumarPuntos;
    }

    void SumarPuntos(int puntos)
    {
        this.puntos += puntos;
        textMesh.text = "Puntos: " + this.puntos;
    }
}
