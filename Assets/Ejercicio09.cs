/*9. Realizá un programa que resuelva el siguiente problema:  
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;
    public float monto1;
    public float monto2;
    public float monto3;
    // Start is called before the first frame update
    void Start()
    {
        float montotal = monto1 + monto2 + monto3;
        float porcentaje1;
        float porcentaje2;
        float porcentaje3;

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
