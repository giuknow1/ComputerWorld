using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{ 
    public float v_mov = 10.0f;
    public bool canMove = true;
    public bool can2 = false;
    public GameObject Pad;
    public static bool padactive = false;
    public static bool inv = false;
    
    public void ControlMovimiento ()
    {
        if (canMove == true)
        {
            v_mov = 5.0f;
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
    }

    void Update()
    {
        PAD();
     
        ControlMovimiento();
        if (!padactive && !inv)
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
        if (Input.GetKeyDown(KeyCode.K))
        {
            Pad.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            padactive = true;
        }
    }
}