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
    public GameObject Cinta;
    public GameObject Tarjeta;
    public GameObject Papel;
    public GameObject Llave1;
    public GameObject Llave2;
    public GameObject Lapiz;
    public GameObject nightvision;
    public GameObject Business;
    public GameObject Numbers;
    public GameObject Money;
    public GameObject People;


 

    public bool slot0 = false;
    public static bool slot1 = false;
    public static bool slot2 = false;
    public bool slot3 = false;
    public static bool slot4 = false;
    public static bool slot5 = false;
    public static bool slot6 = false;
    public bool slot7 = false;
    public static bool slot8 = false;
    public static bool slot9 = false;
    public bool slot10 = false;
    public static bool slot11 = false;
    public bool slot12 = false;
    public bool slot13 = false;
    public bool slot14 = false;
    public bool slot15 = false;

    public bool inv_control = false;
    public bool abrir_descripcion;
    public bool abrir_inv;

    public GameObject Selector;

    public GameObject Cursor0;
    public GameObject Cursor1;

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

        if (inv_coll.CompareTag("Cinta"))
        {

            slot5 = true;
            Bolsa[5].GetComponent<Image>().enabled = true;
            Bolsa[5].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Tarjeta"))
        {

            slot6 = true;
            Bolsa[6].GetComponent<Image>().enabled = true;
            Bolsa[6].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Papel"))
        {

            slot7 = true;
            Bolsa[7].GetComponent<Image>().enabled = true;
            Bolsa[7].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Llave1"))
        {

            slot8 = true;
            Bolsa[8].GetComponent<Image>().enabled = true;
            Bolsa[8].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Llave2"))
        {

            slot9 = true;
            Bolsa[9].GetComponent<Image>().enabled = true;
            Bolsa[9].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Lapiz"))
        {

            slot10 = true;
            Bolsa[10].GetComponent<Image>().enabled = true;
            Bolsa[10].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Nightvision"))
        {

            slot11 = true;
            Bolsa[11].GetComponent<Image>().enabled = true;
            Bolsa[11].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Business"))
        {

            slot12 = true;
            Bolsa[12].GetComponent<Image>().enabled = true;
            Bolsa[12].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Numbers"))
        {

            slot13 = true;
            Bolsa[13].GetComponent<Image>().enabled = true;
            Bolsa[13].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("Money"))
        {

            slot14 = true;
            Bolsa[14].GetComponent<Image>().enabled = true;
            Bolsa[14].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

        }

        if (inv_coll.CompareTag("People"))
        {

            slot15 = true;
            Bolsa[15].GetComponent<Image>().enabled = true;
            Bolsa[15].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;

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

        if ((slot5 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 5) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Cinta.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot6 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 6) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Tarjeta.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot7 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 7) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Papel.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot8 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 8) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Llave1.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot9 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 9) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Llave2.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot10 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 10) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Lapiz.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot11 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 11) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            nightvision.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot12 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 12) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Business.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot13 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 13) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Numbers.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot14 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 14) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            Money.SetActive(true);
            Selector.SetActive(false);
            inv_control = true;
        }

        if ((slot15 == true) && (Input.GetKeyDown(KeyCode.Q)) && (ID == 15) && (abrir_inv) && (inv_control == false))
        {
            GestorDeAudio.instancia.ReproducirSonido("Inspeccionar");
            People.SetActive(true);
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
        Cinta.SetActive(false);
        Tarjeta.SetActive(false);
        Papel.SetActive(false);
        Llave1.SetActive(false);
        Llave2.SetActive(false);
        Lapiz.SetActive(false);
        nightvision.SetActive(false);
        Business.SetActive(false);
        Numbers.SetActive(false);
        Money.SetActive(false);
        People.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Slots();
  
        NavegarEnInventario();

        if (abrir_inv && Menu.menu_screen == false)
        {
            Jugador.inv = true;
            inventario.SetActive(true);
            Selector.SetActive(true);
            Cursor1.SetActive(false);
            Cursor0.SetActive(false);

        }
        else
        {
            GestorDeAudio.instancia.ReproducirSonido("Inventario");
            inventario.SetActive(false);
            Selector.SetActive(false);
            Cursor1.SetActive(true);
            Cursor0.SetActive(true);
            Jugador.inv = false;
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
                Cinta.SetActive(false);
                Tarjeta.SetActive(false);
                Papel.SetActive(false);
                Llave1.SetActive(false);
                Llave2.SetActive(false);
                Lapiz.SetActive(false);
                nightvision.SetActive(false);
                Business.SetActive(false);
                Numbers.SetActive(false);
                Money.SetActive(false);
                People.SetActive(false);

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

    