using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{

    public GameObject Darkness_effect;
    public bool Activar = false;


    void Start()
    {
        Darkness_effect.SetActive(false);
    }
    

    void Update()
    {

        ActivarDark();

        if (Activar) {

            if (!NightVision.NV_estado)
            {

                Darkness_effect.SetActive(true);
            }
            
        } 
    }

    public void ActivarDark()
    {
        if (Input.GetKeyDown(KeyCode.M) && !Activar)
        {
            GestorDeAudio.instancia.ReproducirSonido("BlackOut");
            Activar = true;
        }
    }

}
