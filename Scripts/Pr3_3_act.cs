using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_3_act : MonoBehaviour
{
    Pr3_3_not notificador;

    // si se da el evento de onCloser cambiar el color de la esfera y hacer que salte
    void Start()
    {
        notificador = GameObject.Find("CubeG").GetComponent<Pr3_3_not>();
        notificador.onCloserEvent += ChangeColor;
        notificador.onCloserEvent += Jump;
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 5);
    }
}