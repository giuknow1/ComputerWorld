using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public static bool reset = false;
    public GameObject dead;

    void Update()
    {
        if (reset && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            dead.SetActive(false);
            Stress.stress = 0f;
            Menu.menu_screen = false;
            Cursor.lockState = CursorLockMode.None;
            Jugador.padactive = false;
            Jugador.inv = false;
            GestorDeAudio.instancia.PausarSonido("Computer World");
            GestorDeAudio.instancia.PausarSonido("Ambiance");
            GestorDeAudio.instancia.PausarSonido("WinSong");
            reset = false;
            
        }
    }
}
