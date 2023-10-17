using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr3_2_not : MonoBehaviour
{
    public delegate void OnEventContact1();
    public event OnEventContact1 onEventContact1;
    public delegate void OnEventContact2();
    public event OnEventContact2 onEventContact2;

    void OnTriggerEnter(Collider collision)
    {   
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "g1" && onEventContact1 != null)
        {
            onEventContact1();
        } 
        else if (collision.gameObject.tag != "g1" && onEventContact2 != null)
        {
            onEventContact2();
        }
    }

    void OnCollisionEnter(Collision collision)
    {   
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "g1" && onEventContact1 != null)
        {
            onEventContact1();
        }
        else if (collision.gameObject.tag != "g1" && onEventContact2 != null)
        {
            onEventContact2();
        }
    }
}
