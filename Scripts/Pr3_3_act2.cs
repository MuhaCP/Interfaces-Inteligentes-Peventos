using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_3_act2 : MonoBehaviour
{
        Pr3_3_not notificador;

    // si se da el evento de onCloser hacer que la esfera se oriente hacia SphereB

    void Start()
    {
        notificador = GameObject.Find("CubeG").GetComponent<Pr3_3_not>();
        notificador.onCloserEvent += Orientate;
    }

    void Orientate()
    {
        transform.LookAt(GameObject.Find("SphereB").transform);
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red, 0.1f);
    }

}
