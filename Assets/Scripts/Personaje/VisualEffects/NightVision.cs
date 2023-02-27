using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightVision : MonoBehaviour
{

    public GameObject NightVisionObject;
    public GameObject Target;
    public static bool NV_estado = false;

    void Start()
    {
        NightVisionObject.SetActive(false);
        Target.SetActive(false);
    }


    void Update()
    {
        NightVisionEffect();
    }

    public void NightVisionEffect()
    {
        if (Inventario.slot11) {
            if (Input.GetKeyDown(KeyCode.N))
            {
                NV_estado = !NV_estado;

                if (NV_estado)
                {
                    GestorDeAudio.instancia.ReproducirSonido("NV");
                    GestorDeAudio.instancia.ReproducirSonido("Static");
                    NightVisionObject.SetActive(true);
                    Target.SetActive(true);
                }

                if (!NV_estado)
                {
                    GestorDeAudio.instancia.ReproducirSonido("Radio Boton");
                    GestorDeAudio.instancia.PausarSonido("Static");
                    NightVisionObject.SetActive(false);
                    Target.SetActive(false);
                }
            }
        }
    }
}
