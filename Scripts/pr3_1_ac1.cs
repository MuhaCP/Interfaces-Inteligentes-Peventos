using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr3_1_ac1 : MonoBehaviour
{
    // en el caso de que se de el evento de on event cambiar color de la esfera

    pr3_1_not notificador;
    void Start()
    {
        notificador = GameObject.Find("Cylinder1").GetComponent<pr3_1_not>();
        notificador.onEvent += ChangeColor;
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
