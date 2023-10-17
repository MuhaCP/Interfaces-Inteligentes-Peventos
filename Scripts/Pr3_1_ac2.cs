using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_1_ac2 : MonoBehaviour
{
   // en el caso de que se de el evento de on event mover la esfera hacia el cilindro

    pr3_1_not notificador;
    public float speed;
    public GameObject cylinder;

    void Start()
    {
        notificador = GameObject.Find("Cylinder1").GetComponent<pr3_1_not>();
        notificador.onEvent += MoveSphere;
    }

    void MoveSphere()
    {
        transform.position = Vector3.MoveTowards(transform.position, cylinder.transform.position, speed * Time.deltaTime);
    }

}
