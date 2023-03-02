using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{

    public GameObject Darkness_effect;
    public bool Activar = false;
    public static bool Activarfirst = false;


    void Start()
    {
        Darkness_effect.SetActive(false);
    }
    

    void Update()
    {


        if (Activarfirst)
        {
            Activarfirst = false;
            Darkness_effect.SetActive(true);
            Activar = true;
        }

        if (Activar) {

            if (!NightVision.NV_estado && !ReparacionCables.FinDark)
            {

                Darkness_effect.SetActive(true);
            }
            
        } 
    }

    

}
