using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{


    public GameObject menu;
    public static bool menu_screen = true;

    void Start()
    {
        GestorDeAudio.instancia.ReproducirSonido("Menu");
        Cursor.lockState = CursorLockMode.None;
    }


    void Update()
    {
        key();
    }

    private void Jugar()
    {
        menu.SetActive(false);
        menu_screen = false;
        GestorDeAudio.instancia.PausarSonido("Menu");
        Cursor.lockState = CursorLockMode.Locked;
        GestorDeAudio.instancia.ReproducirSonido("Correct");
    }

    public void key()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && menu_screen)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
