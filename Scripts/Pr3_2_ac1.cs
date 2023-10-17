using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_2_ac1 : MonoBehaviour
{
   // en el caso de que se de el evento de on event mover la esfera hacia el cilindro

    pr3_2_not notificador;
    public float speed = 5;
    public GameObject cylinder;

    void Start()
    {
        notificador = GameObject.Find("CubeG").GetComponent<pr3_2_not>();
        notificador.onEventContact2 += MoveSphere;
    }

    void MoveSphere()
    {
        transform.position = Vector3.MoveTowards(transform.position, cylinder.transform.position, speed * Time.deltaTime);
    }

}
