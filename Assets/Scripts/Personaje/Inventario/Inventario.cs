using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bolsa = new List<GameObject>();

    public GameObject inventario;

    public GameObject casete;
    public GameObject calculadora;
    public GameObject linterna;
    public GameObject consola;
    public GameObject Drill;

    public bool slot0 = false;
    public bool slot1 = false;
    public bool slot2 = false;
    public bool slot3 = false;
    public bool slot4 = false;

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

        if (inv_coll.CompareTag("Calculadora"))
        {

            slot1 = true;
            Bolsa[1].GetComponent<Image>().enabled = true;
            Bolsa[1].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }


        if (inv_coll.CompareTag("Linterna"))
        {

            slot2 = true;
            Bolsa[2].GetComponent<Image>().enabled = true;
            Bolsa[2].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Consola"))
        {

            slot3 = true;
            Bolsa[3].GetComponent<Image>().enabled = true;
            Bolsa[3].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Drill"))
        {

            slot4 = true;
            Bolsa[4].GetComponent<Image>().enabled = true;
            Bolsa[4].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }
    }


    void Slots() { 
    
        if ((slot0 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 0) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            casete.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }


        if ((slot1 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 1) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            calculadora.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }


        if ((slot2 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 2) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            linterna.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }


        if ((slot3 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 3) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            consola.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }


        if ((slot4 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 4) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Drill.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }
    }


    public void NavegarEnInventario()
    {
        if (abrir_inv && inv_control == false)
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
        calculadora.SetActive(false);
        linterna.SetActive(false);
        consola.SetActive(false);
        Drill.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Slots();

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
            ID = 0;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inv_control == true)
            {
                casete.SetActive(false);
                calculadora.SetActive(false);
                linterna.SetActive(false);
                consola.SetActive(false);
                Drill.SetActive(false);
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

    