using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bolsa = new List<GameObject>();

    public GameObject inventario;
    public GameObject casete;

    public bool slot0 = false;

    public bool inv_control = false;
    public bool abrir_descripcion;
    public bool abrir_inv;

    public GameObject Selector;
    public int ID;
   

    void OnTriggerEnter(Collider inv_coll)
    {
        if (inv_coll.CompareTag("Item"))
        {

            slot0 = true;
            Bolsa[0].GetComponent<Image>().enabled = true;
            Bolsa[0].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;
           
        }
    }


    void Slot0() { 
    
        if ((slot0 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 0) && (abrir_inv))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            casete.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }
    }


    public void NavegarEnInventario()
    {
        if (abrir_inv)
        {
            if (Input.GetKeyDown(KeyCode.D) && ID < Bolsa.Count - 1)
            {
                ID++;
          
                GestorDeAudio.instancia.ReproducirSonido("Slot");
            }

            if (Input.GetKeyDown(KeyCode.A) && ID > 0)
            {
                ID--;
          
                GestorDeAudio.instancia.ReproducirSonido("Slot");
            }

            if (Input.GetKeyDown(KeyCode.W) && ID > 3)
            {
                ID -= 4;
    
                GestorDeAudio.instancia.ReproducirSonido("Slot");
            }

            if (Input.GetKeyDown(KeyCode.S) && ID < 12)
            {
                ID += 4;
   
                GestorDeAudio.instancia.ReproducirSonido("Slot");
            }

            Selector.transform.position = Bolsa[ID].transform.position;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        casete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Slot0();
        NavegarEnInventario();

        if (abrir_inv)
        {

            inventario.SetActive(true);
            Selector.SetActive(true);

        }
        else
        {
            GestorDeAudio.instancia.ReproducirSonido("Inventario");
            inventario.SetActive(false);
            Selector.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inv_control == true)
            {
                casete.SetActive(false);
                Selector.SetActive(true);
                inv_control = false;

            }
            else
            {
                abrir_inv = !abrir_inv;
            }



        }


    }
}

    