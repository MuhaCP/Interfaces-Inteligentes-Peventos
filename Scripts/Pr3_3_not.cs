using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3_3_not : MonoBehaviour
{
    // detectar si el objeto se acerca a otro objeto y activar un evento
    public delegate void onCloser();
    public event onCloser onCloserEvent;

    public GameObject target;

    float distance;

    void start()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
    }

    void Update()
    {
        float newDistance = Vector3.Distance(transform.position, target.transform.position);
        if (newDistance < distance)
        {
            if (onCloserEvent != null)
            {
                onCloserEvent();
            }
        }
        distance = newDistance;
    }    
}
