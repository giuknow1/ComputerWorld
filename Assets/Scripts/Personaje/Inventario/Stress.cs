using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stress : MonoBehaviour
{
    public Slider stress_bar;
    public float stress = 100f;
    public bool reduccion = false;
    public GameObject casete_ref;
    public static bool activar_evento_radio = false;

    public bool rebobinar = false;

    public bool control = true;
    public bool control_reb = true;
    public bool casete = false;

    private void Musica()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (!rebobinar))
        {
            control = false;
            activar_evento_radio = false;
            reduccion = true;
            GestorDeAudio.instancia.ReproducirSonido("Computer World");
            casete_ref.SetActive(false);
            StartCoroutine(time());
            StartCoroutine(MSC());
        } 
        else if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (rebobinar) && (control_reb))
        {
            control_reb = false;
            GestorDeAudio.instancia.ReproducirSonido("Rebobinar");
            StartCoroutine(rebob());
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
                stress -= 0.1f;
            }
        }

    }

    IEnumerator MSC()
    {
        yield return new WaitForSeconds(140f);
        reduccion = false;
        control = true;
        casete_ref.SetActive(true);
        rebobinar = true;
        control_reb = true;
    }

    IEnumerator rebob()
    {
            yield return new WaitForSeconds(19f);
            rebobinar = false;
        }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") == true)
        {
            other.gameObject.SetActive(false);
            casete = true;
        }
    }

    }


