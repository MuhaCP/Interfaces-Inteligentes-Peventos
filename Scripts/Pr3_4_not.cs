using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_4_not : MonoBehaviour
{
    public delegate void OnEventCollection(int points);
    public event OnEventCollection onEventCollection;

    void OnCollisionEnter(Collision collision)
    {
        //Las esferas de tipo 1 suman 5 puntos y las esferas de tipo 2 suman 10
        if (collision.gameObject.tag == "g1" && onEventCollection != null)
        {
            onEventCollection(1);
            //eliminamos la esfera
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "g2" && onEventCollection != null)
        {
            onEventCollection(5);
            //eliminamos la esfera
            Destroy(collision.gameObject);
        }
    }
}
