using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadCode : MonoBehaviour
{
    [SerializeField] private Text Ans;
    public GameObject keypad;

    public Animator Porton3;

    public string answer = "1234";


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
        PortonIII();

        if (Ans.text == answer)
        {
           

            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
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

 public void PortonIII()
    {
        if (Ans.text == "911")
        {
            Porton3.Play("Porton3");
            GestorDeAudio.instancia.ReproducirSonido("Gate");
            GestorDeAudio.instancia.ReproducirSonido("Correct");
            keypad.SetActive(false);
            Ans.text = "";
        }
    }

}
