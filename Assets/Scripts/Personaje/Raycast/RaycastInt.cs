using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInt : MonoBehaviour
{
    public new Transform camera;
    public GameObject cursor;
    public float rayDistance;

    public bool vent = false;

    //---
   
    //---

    public GameObject caja;

    public int contador = 4;

    RaycastHit view;

    void start()
    {
        camera = transform.Find("Camara Jugador");
       
    }

    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        if (Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Interactuable")) || Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("IntRadio")) ||
            Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Tornillo")) || Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Tornillo2")) ||
            Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Tornillo3")) || Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Tornillo4")) ||
            Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("Cable")) || Physics.Raycast(camera.position, camera.forward, out view, rayDistance, LayerMask.GetMask("CableRep")) )
        {
            cursor.SetActive(false);
        } else
        {
            cursor.SetActive(true);
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactuable")))
            {
                hit.transform.GetComponent<Interactuable>().Radio();
            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("IntRadio")))
            {
                hit.transform.GetComponent<Audio>().Audio1();
                
            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Tornillo")) && Inventario.slot4 == true)
            {
               
                hit.transform.GetComponent<TornillosCaja>().Tornillo();
                contador--;

            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Tornillo2")) && Inventario.slot4 == true)
            {

                hit.transform.GetComponent<TornillosCaja>().Tornillo2();
                contador--;

            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Tornillo3")) && Inventario.slot4 == true)
            {

                hit.transform.GetComponent<TornillosCaja>().Tornillo3();
                contador--;
            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Tornillo4")) && Inventario.slot4 == true)
            {

                hit.transform.GetComponent<TornillosCaja>().Tornillo4();
                contador--;

            }


            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Cable")) && contador == 0)
            {

                hit.transform.GetComponent<Cables>().Wires();
              
            }


            if (contador == 0 && vent == false)
            {
                vent = true;
                caja.SetActive(false);
                GestorDeAudio.instancia.ReproducirSonido("Vent");
            }

            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("CableRep")) && Inventario.slot5 == true)
            {
                if (Cableado.reparacion == 1)
                {
                    hit.transform.GetComponent<RepCables>().Reparacion();
                }
            }


        }
    }

    
}


