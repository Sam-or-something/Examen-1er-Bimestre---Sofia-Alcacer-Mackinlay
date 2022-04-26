using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantTaxis;
    public int cantDias;
    public int cantDiasLluvia;
    int recorridoTotal;
    int precioTotal;


    // Start is called before the first frame update
    void Start()
    {
        if (cantDias < 5 || cantDiasLluvia < 0 || cantDiasLluvia > cantDias)
        {
            Debug.Log("Error, por favor ingresar valores correctos");
        }
        else
        {
            recorridoTotal = cantTaxis * (cantDias * 90 + cantDiasLluvia * 30);
            precioTotal = (recorridoTotal / 15) * 130;
            Debug.Log("“Una flota de " + cantTaxis + " unidades trabajando durante " + cantDias + " días implicará un gasto de " + precioTotal + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
