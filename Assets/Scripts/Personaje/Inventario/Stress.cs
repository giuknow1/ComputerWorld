using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stress : MonoBehaviour
{
    public Slider stress_bar;
    public float stress = 100f;
    public bool reduccion = false;

    private void Musica()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            reduccion = true;
            GestorDeAudio.instancia.ReproducirSonido("Computer World");
            StartCoroutine(time());
            StartCoroutine(MSC());
        }
    }

    private void Update()
    {
        
        stress_bar.GetComponent<Slider>().value = stress;
        Musica();
        
    }

    IEnumerator time()
    {

        while(reduccion)
        {
            yield return new WaitForSeconds(0.1f);
            if(stress > 0)
            {
                stress -= 0.075f;
            }
        }

    }

    IEnumerator MSC()
    {
        yield return new WaitForSeconds(140f);
        GestorDeAudio.instancia.ReproducirSonido("Stop");
        yield return new WaitForSeconds(1f);
        GestorDeAudio.instancia.PausarSonido("Computer World");
        reduccion = false;
    }
}


