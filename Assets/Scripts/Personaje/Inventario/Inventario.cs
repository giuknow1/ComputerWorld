using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bolsa = new List<GameObject>();
    public GameObject inventario;
    public bool abrir_inv;

    public GameObject Selector;
    public int ID;

    void OnTriggerEnter(Collider inv_coll)
    {
        if (inv_coll.CompareTag("Item"))
        {
            for (int i = 0; i < Bolsa.Count; i++)
            {
                if (Bolsa[i].GetComponent<Image>().enabled == false)
                {
                    Bolsa[i].GetComponent<Image>().enabled = true;
                    Bolsa[i].GetComponent<Image>().sprite = inv_coll.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
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
        
    }

    // Update is called once per frame
    void Update()
    {

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
            abrir_inv = !abrir_inv;
            
        }
    }         

    
}
    