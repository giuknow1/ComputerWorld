using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarjeta : MonoBehaviour
{
    public Animator Left;
    public Animator Right;
    

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("TDoor") == true)
            {
                Left.Play("LeftTarjeta");
                Right.Play("RightTarjeta");
            }
        }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TDoor") == true)
        {
            Left.Play("LT2");
            Right.Play("RT2");
        }
    }

}
