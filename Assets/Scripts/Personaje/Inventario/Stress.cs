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
    public bool insert = true;

    public Image stressImage;
    private float r;
    private float g;
    private float b;
    private float a;




    void Start()
    {
      

        r = stressImage.color.r;
        g = stressImage.color.g;
        b = stressImage.color.b;
        a = stressImage.color.a;
    }

    private void Musica()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (!rebobinar) && (!insert))
        {
            control = false;
            activar_evento_radio = false;
            reduccion = true;
            GestorDeAudio.instancia.ReproducirSonido("Computer World");
            StartCoroutine(time());
            StartCoroutine(MSC());
        } 
        else if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (rebobinar) && (control_reb) && (!insert))
        {
            casete_ref.SetActive(false);
            control_reb = false;
            GestorDeAudio.instancia.ReproducirSonido("Rebobinar");
            StartCoroutine(rebob());
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (insert))
        {
            casete_ref.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Insert");
            insert = false;

        }
    }

    private void Update()
    {

        a = Mathf.Clamp(a, 0, 1f);
        Efecto();


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
             
                a -= 0.002f;
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
        insert = true;
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


    private void Efecto()
    {
        Color c = new Color(r, g, b, a);
        stressImage.color = c;
    }
    
 
}

    


