using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public  GameObject data;
    public GameObject menu;
    public static bool menu_screen = true;

    void Start()
    {
        GestorDeAudio.instancia.ReproducirSonido("Menu");
        Cursor.lockState = CursorLockMode.None;
        data.SetActive(false);
    }


    void Update()
    {
        key();
      
    }

    public void Jugar()
    {
        menu.SetActive(false);
        menu_screen = false;
        GestorDeAudio.instancia.PausarSonido("Menu");
        Cursor.lockState = CursorLockMode.Locked;
        GestorDeAudio.instancia.ReproducirSonido("Correct");
        data.SetActive(true);
    }

    public void key()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && menu_screen)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
