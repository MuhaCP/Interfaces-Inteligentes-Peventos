using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr3_2_ac2 : MonoBehaviour
{
    public int incremento = 5;
    pr3_2_not notificador;
    void Start()
    {
        notificador = GameObject.Find("CubeG").GetComponent<pr3_2_not>();
        notificador.onEventContact1 += IncreseSize;
    }

    void IncreseSize()
    {
        transform.localScale += new Vector3(incremento, incremento, incremento);
    }
        
}
