using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    public int horActual;
    
    // Start is called before the first frame update
    void Start()
    {
        int HORA_APERTURA = 10;
        int HORA_CIERRE = 18;
        bool estaAbierto = true;

        if (horActual < 0 || horActual > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
        else
        {
            if (horActual < HORA_APERTURA && horActual > HORA_CIERRE)
            {
                estaAbierto = false;
            }

            if (estaAbierto == true)
            {
                Debug.Log("El estacionamiento esta abierto");
            }
            else
            {
                Debug.Log("El estacionamiento esta cerrado");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
