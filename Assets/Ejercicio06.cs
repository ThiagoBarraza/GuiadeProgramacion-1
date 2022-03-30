using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{
    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (num1 < 0)
        {
            Debug.Log("Por favor ingrese numeros mayores a 0");
        }
        else
        {
             num1 = num1 % 2;
            if (num1 == 0)
            {
                Debug.Log("El numero ingresado es par");
            }
            else{
                Debug.Log("El numero ingresado es impar");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
