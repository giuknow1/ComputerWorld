using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : Lockers
{

    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;



    public override void abrirLocker1()
    {
      if (Inventario.slot9)

        {
            GestorDeAudio.instancia.ReproducirSonido("Locker");
            puerta1.SetActive(false);
        }
    }
    

    public override void abrirLocker2()
    {
        if (Inventario.slot9)

        {
            GestorDeAudio.instancia.ReproducirSonido("Locker");
            puerta2.SetActive(false);
        }
    }


    public override void abrirLocker3()
    {
        if (Inventario.slot8)

        {
            GestorDeAudio.instancia.ReproducirSonido("Locker");
            puerta3.SetActive(false);
        }
    }
}
