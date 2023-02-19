using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colisiones : MonoBehaviour
{
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Calculadora") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Linterna") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }


        if (other.gameObject.CompareTag("Consola") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Drill") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Cinta") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Tarjeta") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Papel") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Llave1") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Llave2") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if (other.gameObject.CompareTag("Lapiz") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }

        if(other.gameObject.CompareTag("Nightvision") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bag");
        }
    }




        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
