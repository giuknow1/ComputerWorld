using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReparacionCables : RepCables
{

    public int rep = 6;
    public static bool FinDark = false;

    public GameObject cablerep1;
    public GameObject cablerep2;
    public GameObject cablerep3;
    public GameObject cablerep4;
    public GameObject cablerep5;


    public GameObject Dark;

    public override void Reparacion()
    {
        rep--;
       

        if (rep == 5)
            {
                cablerep1.SetActive(true);
              
            } else

            if (rep == 4)
            {
             
                cablerep2.SetActive(true);
            } else

            if (rep == 3)
            {
               
                cablerep3.SetActive(true);
            } else

            if (rep == 2)
            {
               
                cablerep4.SetActive(true);
            } else

            if (rep == 1)
            {
              
                cablerep5.SetActive(true);
            Dark.SetActive(false);
            FinDark = true;
            GestorDeAudio.instancia.ReproducirSonido("LightOn");
        }

        
    }
}
