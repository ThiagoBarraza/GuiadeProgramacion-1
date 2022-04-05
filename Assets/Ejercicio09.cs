using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;
    public int monto1;
    public int monto2;
    public int monto3;
    // Start is called before the first frame update
    void Start()
    {
        int montotal = monto1 + monto2 + monto3;
        int porcentaje1;
        int porcentaje2;
        int porcentaje3;

        porcentaje1 = monto1 * 100 / montotal;
        porcentaje2 = monto2 * 100 / montotal;
        porcentaje3 = monto3 * 100 / montotal;


        Debug.Log("Nombre: " + nombre1 + " capital aportado: $" + monto1 + "  ,Porcentaje del capital: %" + porcentaje1 + " , Monto total aportado: $" + montotal );
        Debug.Log("Nombre: " + nombre2 + " capital aportado: $" + monto2 + "  ,Porcentaje del capital: %" + porcentaje2 + " , Monto total aportado: $" + montotal);
        Debug.Log("Nombre: " + nombre3 + " capital aportado: $" + monto3 + "  ,Porcentaje del capital: %" + porcentaje3 + " , Monto total aportado: $" + montotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
