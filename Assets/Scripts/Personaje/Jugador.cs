using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{ 
    public static float v_mov = 10.0f;
    public bool canMove = true;
    public bool can2 = false;
    public GameObject Pad;
    public static bool padactive = false;
    public static bool inv = false;
    public GameObject subs;
    public GameObject data;

    public void ControlMovimiento ()
    {
        if (canMove == true && Porton.estado2 == false)
        {
            v_mov = 5.0f;
        }

        if (canMove == true && Porton.estado2 == true)
        {
            v_mov = 2.0f;
        }

        if (canMove == false)
        {
            v_mov = 0.0f;
        }
    }

   
    void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked;
        Pad.SetActive(false);
        subs.SetActive(false);
    }

    void Update()
    {
        PAD();

        if (Input.GetKeyDown(KeyCode.E))
        {
            data.SetActive(false);
        }

        ControlMovimiento();
        if (!padactive && !inv && Menu.menu_screen == false)
        {
            float movimientoAdelanteAtras = Input.GetAxis("Vertical") * v_mov;
            float movimientoCostados = Input.GetAxis("Horizontal") * v_mov;
            movimientoAdelanteAtras *= Time.deltaTime;
            movimientoCostados *= Time.deltaTime;
            transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

            if (Input.GetKeyDown("escape"))
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }
        }
    
    //Temporal
    public void PAD()
    {
        if (Input.GetKeyDown(KeyCode.K) && Menu.menu_screen == false)
        {
            Pad.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            padactive = true;
        }
    }
}