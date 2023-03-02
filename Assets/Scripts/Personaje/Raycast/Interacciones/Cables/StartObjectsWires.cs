using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObjectsWires : MonoBehaviour
{
    public GameObject cablerep1;
    public GameObject cablerep2;
    public GameObject cablerep3;
    public GameObject cablerep4;
    public GameObject cablerep5;



    void Start()
    {

        cablerep1.SetActive(false);
        cablerep2.SetActive(false);
        cablerep3.SetActive(false);
        cablerep4.SetActive(false);
        cablerep5.SetActive(false);
    }

  
}
