using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr3_1_not : MonoBehaviour
{
    // en el caso de que haya una colision con el objeto llamado Cylinder1 se activa en evento
    public delegate void OnEvent();
    public event OnEvent onEvent;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "CubeG" && onEvent != null)
        {
            onEvent();
        }
    }
}
