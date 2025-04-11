using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour
{
    public string codigoHelado;
    public float cantidadDeGramosPedida;
    float descuentoFrutilla = 0.1F;
    float cantidadMaxima = 3000;
    float cantidadMinima = 250;
    float precioGramo = 1.25F;
    float precio;
    void Start()
    { 
        if(cantidadDeGramosPedida < 250 || cantidadDeGramosPedida > 3000)
        {
            Debug.Log("ERROR. Cantidad pedida no dentro de los parametros (250 - 3000)");
        }
        else
        {
            if (codigoHelado == "DDL")
            {
                precio = precioGramo * cantidadDeGramosPedida;
                Debug.Log("El precio de tu helado de dulce de leche de " + cantidadDeGramosPedida + " gramos es de: " + precio + "$");
                return;
            }
            else if(codigoHelado == "CHO")
            {
                precio = precioGramo * cantidadDeGramosPedida;
                Debug.Log("El precio de tu helado de chocolate de " + cantidadDeGramosPedida + " gramos es de: " + precio + "$");
                return;
            }
            else if(codigoHelado == "FRU")
            {
                precio = precioGramo * cantidadDeGramosPedida;
                precio -= precio * descuentoFrutilla;
                Debug.Log("El precio de tu helado de frutilla de " + cantidadDeGramosPedida + " gramos es de: " + precio + "$, estas usando un descuento del 10%");
                return;
            }
            else
            {
                Debug.Log(" ERROR. Ingrese un codigo valido, (DDL, CHO, FRU)");
            }
         
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
