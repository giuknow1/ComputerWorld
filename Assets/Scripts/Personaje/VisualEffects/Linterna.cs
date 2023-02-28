using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light foco;
    public Light luzLinterna;
    public bool estado = false;

    public new Transform camera;
   
    public float rayDistance;

    public GameObject secret1;


    RaycastHit view;

    void Start()
    {
        camera = transform.Find("Camara Jugador");
        secret1.SetActive(false);

        luzLinterna.enabled = false;

        foco.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            estado = !estado;
            GestorDeAudio.instancia.ReproducirSonido("Radio Boton");

            if (estado)
            {
                foco.enabled = true;
                luzLinterna.enabled = true;
            }
            else
            {
                foco.enabled = false;
                luzLinterna.enabled = false;
            }
        }

        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        if (Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Secret")) && (estado))
        {
            secret1.SetActive(true);
        }
        else
        {
            secret1.SetActive(false);
        }

        //

       



    }

 
}
