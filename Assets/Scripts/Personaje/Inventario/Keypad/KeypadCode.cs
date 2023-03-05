using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadCode : MonoBehaviour
{
    [SerializeField] private Text Ans;

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


}
