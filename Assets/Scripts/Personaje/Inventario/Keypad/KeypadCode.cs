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
      

        if (Ans.text == answer)
        {
           

            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Ans.text == "1981")
        {

            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Porton1.Play("Porton1");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
        }
        else if (Ans.text == "1357")
        {
            Porton3.Play("Porton3");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;

        } else if (Ans.text == "4273")
        {

            GestorDeAudio.instancia.ReproducirSonido("Vent");
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Numbers.SetActive(true);

        }
        else if (Ans.text == "41")
        {

            
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
            Cursor.lockState = CursorLockMode.Locked;
            Bath.Play("BathDoor");

        }
        else

        {
            Ans.text = "ERROR";
            GestorDeAudio.instancia.ReproducirSonido("Error");
            StartCoroutine(time());
            Stress.stress += 10f;
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
    }

}
