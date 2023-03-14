using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadCode : MonoBehaviour
{
    [SerializeField] private Text Ans;
    public GameObject keypad;

    public Animator Porton3;
    public Animator Porton1;
    public Animator Bath;
    public Animator End;
    public GameObject Numbers;

    public string answer = "1234";

    void Start()
    {
        Numbers.SetActive(false);
    }

    void Update()
    {
       
    }

    public void Number(int num)
    {
        Ans.text += num.ToString();
        GestorDeAudio.instancia.ReproducirSonido("Key");
    }

    public void Execute()
    {
      

        if (Ans.text == "1981")
        {

            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Porton1.Play("Porton1");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            Jugador.padactive = false;
        }
        else if (Ans.text == "1357")
        {
            Porton3.Play("Porton3");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Jugador.padactive = false;

        } else if (Ans.text == "4273")
        {

            GestorDeAudio.instancia.ReproducirSonido("Vent");
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Numbers.SetActive(true);
            Jugador.padactive = false;
        }
        else if (Ans.text == "48")
        {

            
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Bath.Play("BathDoor");
            Jugador.padactive = false;
        }
        else if (Ans.text == "87541")
        {


            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            End.Play("EndDoor");
            Jugador.padactive = false;
            GestorDeAudio.instancia.ReproducirSonido("WinSong");
            GestorDeAudio.instancia.PausarSonido("Computer World");
        }
        else

        {
            Ans.text = "ERROR";
            GestorDeAudio.instancia.ReproducirSonido("Error");
            StartCoroutine(time());
            Stress.stress += 15f;
            Stress.a += 0.1f;

        }
    }

    public void Delete()
    {
        Ans.text = "";
        GestorDeAudio.instancia.ReproducirSonido("Key");
    }


    IEnumerator time()
    {
        yield return new WaitForSeconds(1f);
        Ans.text = "";
    }


    public void Close()
    {
        GestorDeAudio.instancia.ReproducirSonido("Key");
        keypad.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Jugador.padactive = false;
    }

}
