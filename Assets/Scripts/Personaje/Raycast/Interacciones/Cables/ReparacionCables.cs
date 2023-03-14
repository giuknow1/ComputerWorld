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

    public Animator Porton3;
    public Animator Errordoor;
    public Animator Close;

    public GameObject Dark;

    public override void Reparacion()
    {
        rep--;
       

        if (rep == 5)
            {
                cablerep1.SetActive(true);
            GestorDeAudio.instancia.ReproducirSonido("Cinta");
        } else

            if (rep == 4)
            {
            GestorDeAudio.instancia.ReproducirSonido("Cinta");
            cablerep2.SetActive(true);
            } else

            if (rep == 3)
            {
            GestorDeAudio.instancia.ReproducirSonido("Cinta");
            cablerep3.SetActive(true);
            } else

            if (rep == 2)
            {
            GestorDeAudio.instancia.ReproducirSonido("Cinta");
            cablerep4.SetActive(true);
            } else

            if (rep == 1)
            {
            GestorDeAudio.instancia.ReproducirSonido("Cinta");
            cablerep5.SetActive(true);
            Dark.SetActive(false);
            FinDark = true;
            GestorDeAudio.instancia.ReproducirSonido("LightOn");
            GestorDeAudio.instancia.ReproducirSonido("TurnOn");
            Errordoor.Play("ErrorDoor");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            Porton3.Play("Porton3");
            Close.Play("Porton4 Close");
            Tarjeta.light = true;
        }

        
    }
}
