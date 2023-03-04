using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarjeta : MonoBehaviour
{
    public Animator Left;
    public Animator Right;
    public AudioClip Puerta;
    public bool estado = true;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("TDoor") == true && (estado) && (Inventario.slot6))
            {
            estado = false;
            AudioSource.PlayClipAtPoint(Puerta, transform.position, 0.5f);
            Left.Play("LeftTarjeta");
                Right.Play("RightTarjeta");
            StartCoroutine(Animation());
           
        }
        }




    IEnumerator Animation()
    {
        yield return new WaitForSeconds(4.5f);
        Left.Play("LT2");
        Right.Play("RT2");
        estado = true;
    }

}
