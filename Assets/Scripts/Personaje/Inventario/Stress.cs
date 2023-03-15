using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stress : Interactuable
{
    public Slider stress_bar;
    public static float stress = 0f;
    public bool reduccion = false;
    public GameObject casete_ref;
    public static bool activar_evento_radio = false;

    

    public bool rebobinar = false;
    public static bool interact = false;

    public bool control = true;
    public bool control_reb = true;
    public bool casete = false;
    public bool insert = true;

    public static bool stress_event = false;
    public static float event_v = 0.0001f;

    public Image stressImage;
    private float r;
    private float g;
    private float b;
    public static float a;


    public GameObject dead_screen;

    void Start()
    {
        dead_screen.SetActive(false);

        r = stressImage.color.r;
        g = stressImage.color.g;
        b = stressImage.color.b;
        a = stressImage.color.a;
        a = 0.0f;
    }

    public override void Musica()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (!rebobinar) && (!insert) && (interact))
        {
            interact = false;
            control = false;
            activar_evento_radio = false;
            reduccion = true;
            GestorDeAudio.instancia.ReproducirSonido("Computer World");
            StartCoroutine(time());
            StartCoroutine(MSC());
            stress_event = false;
            
        } 
        else if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (rebobinar) && (control_reb) && (!insert) && (interact))
        {
            interact = false;
            casete_ref.SetActive(false);
            control_reb = false;
            GestorDeAudio.instancia.ReproducirSonido("Rebobinar");
            StartCoroutine(rebob());
            
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && (activar_evento_radio) && (casete) && (control) && (insert) && (interact))
        {
            interact = false;
            casete_ref.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Insert");
            insert = false;

        }
    }

    private void Update()
    {

        StartCoroutine(Event());

        a = Mathf.Clamp(a, 0, 1f);
        Efecto();


        stress_bar.GetComponent<Slider>().value = stress;
        Musica();

       if (stress >= 100f)
        {
            dead_screen.SetActive(true);
            Menu.menu_screen = true;
            stress_event = false;
            GestorDeAudio.instancia.PausarSonido("Computer World");
            GestorDeAudio.instancia.PausarSonido("Ambiance");
            Reset.reset = true;
          
        }
        
       
    }

    IEnumerator time()
    {

        while(reduccion)
        {
            yield return new WaitForSeconds(0.1f);
            if(stress > 0)
            {
                stress -= 0.4f;
             
                a -= 0.001f;
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
    
 IEnumerator Event()
    {
       while  (stress_event)
        {
            yield return new WaitForSeconds(3f);
            stress += event_v;
        }
    }
}

    


