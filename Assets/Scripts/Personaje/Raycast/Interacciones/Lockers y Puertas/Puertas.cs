using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : Door
{

    public bool openDoor = false;
    public float angle = 95f;
    public float smooth = 3.0f;
    public float closeDoorAngle = 0.0f;


    public override void estadoDoor()
    {
        openDoor = !openDoor;
    }

    public void Update()
    {

        if (openDoor)
        {
            Quaternion targetRotation = Quaternion.Euler(0, angle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        } 
        else if (!openDoor)
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, closeDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }

   
}
