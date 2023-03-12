using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{ 
    public float v_mov = 10.0f;
    public bool canMove = true;
    public bool can2 = false;
    public GameObject Pad;

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

    public void Freeze()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (can2 == true)
            {
                can2 = false;
            } else
            {

                canMove = !canMove;
                can2 = false;
            }

        }

        if (canMove == false && Input.GetKeyDown(KeyCode.Q))
        {
            can2 = true;
        }

    }
    void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        PAD();
        Freeze();
        ControlMovimiento();

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
    
    //Temporal
    public void PAD()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Pad.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}