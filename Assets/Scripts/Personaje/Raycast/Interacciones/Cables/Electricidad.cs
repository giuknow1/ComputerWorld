using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricidad : TornillosCaja
{

   

    public GameObject tornillo1;
    public GameObject tornillo2;
    public GameObject tornillo3;
    public GameObject tornillo4;

    public bool t1 = true;
    public bool t2 = true;
    public bool t3 = true;
    public bool t4 = true;

    public GameObject Caja;
    

    public override void Tornillo()
    {
        tornillo1.SetActive(false);
        t1 = false;
        GestorDeAudio.instancia.ReproducirSonido("Drill");
    }

    public override void Tornillo2()
    {
        tornillo2.SetActive(false);
        t2 = false;
        GestorDeAudio.instancia.ReproducirSonido("Drill");
    }

    public override void Tornillo3()
    {
        tornillo3.SetActive(false);
        t3 = false;
        GestorDeAudio.instancia.ReproducirSonido("Drill");
    }

    public override void Tornillo4()
    {
        tornillo4.SetActive(false);
        t4 = false;
        GestorDeAudio.instancia.ReproducirSonido("Drill");
    }

  
}


