using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioInt : Interactuable
{

  public override void Radio()
    {
        base.Radio();

        Stress.activar_evento_radio = true;
    }
}
