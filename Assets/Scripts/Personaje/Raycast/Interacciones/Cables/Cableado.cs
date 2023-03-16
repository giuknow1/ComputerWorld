using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cableado : Cables
{
    
    public GameObject cable1;
    public GameObject cable2;
    public GameObject cable3;
    public GameObject cable4;
    public GameObject cable5;

    public Animator Door;
    public Animator Open;

    public static int reparacion = 0;
    public static int cablescont = 5;
    

        public override void Wires()
        {
        cablescont--;
        GestorDeAudio.instancia.ReproducirSonido("Wire");

        if (cablescont == 4)
        {
            cable1.SetActive(false);

        }

        if (cablescont == 3)
        {
            cable2.SetActive(false);
        }

        if (cablescont == 2)
        {
            cable3.SetActive(false);
            
        }

        if (cablescont == 1)
        {
            cable4.SetActive(false);
        }

        if (cablescont == 0)
        {
            reparacion = 1;
            cable5.SetActive(false);
            Darkness.Activarfirst = true;
            GestorDeAudio.instancia.ReproducirSonido("BlackOut");
            Door.Play("AbrirPorton");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            Open.Play("Porton4 Open");
            Tarjeta.light = false;
        }


    }
    }
