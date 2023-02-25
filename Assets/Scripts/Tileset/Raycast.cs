using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public new Transform camera;

    public float rayDistance;

    void start()
    {
        camera = transform.Find("Camara Jugador");
    }

    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactuable")))
        {
            Debug.Log(hit.transform.name);
        }
    }

}


