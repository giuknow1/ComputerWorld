using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bolsa = new List<GameObject>();
    public GameObject inventario;
    public bool abrir_inv;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (abrir_inv)
        {
            inventario.SetActive(true); 
        } 
        else
        {
            inventario.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            abrir_inv = !abrir_inv; 
        }
    }         

    
}
    