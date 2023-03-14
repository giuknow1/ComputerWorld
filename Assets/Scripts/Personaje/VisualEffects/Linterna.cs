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
    public GameObject secret2; public GameObject secret3; public GameObject secret4; public GameObject secret5;
    public GameObject MaM;

    RaycastHit view;

    void Start()
    {
        camera = transform.Find("Camara Jugador");
        secret1.SetActive(false);

        secret1.SetActive(false);
        secret2.SetActive(false); secret3.SetActive(false); secret4.SetActive(false); secret5.SetActive(false);
        foco.enabled = false;
        MaM.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && Inventario.slot2 == true)
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
            secret2.SetActive(true); secret3.SetActive(true); secret4.SetActive(true); secret5.SetActive(true); MaM.SetActive(true);
        }
        else
        {
            secret1.SetActive(false);
            secret2.SetActive(false); secret3.SetActive(false); secret4.SetActive(false); secret5.SetActive(false); MaM.SetActive(false);
        }

        //

       



    }

 
}
