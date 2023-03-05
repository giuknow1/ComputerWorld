using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadCode : MonoBehaviour
{
    [SerializeField] private Text Ans;
    public GameObject keypad;


    public string answer = "1234";

    public void Number(int num)
    {
        Ans.text += num.ToString();
        GestorDeAudio.instancia.ReproducirSonido("Key");
    }

    public void Execute()
    {
       
        if (Ans.text == answer)
        {
            Ans.text = "CORERECTO";
            GestorDeAudio.instancia.ReproducirSonido("Correct");
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
    }

}
