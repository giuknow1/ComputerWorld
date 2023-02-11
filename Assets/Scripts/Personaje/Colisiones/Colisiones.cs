using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
