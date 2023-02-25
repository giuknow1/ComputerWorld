using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioInt : Interactuable
{

  public override void Radio()
    {
        base.Radio();
        //
        GestorDeAudio.instancia.ReproducirSonido("Computer World");
    }
}
