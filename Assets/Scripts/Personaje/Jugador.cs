using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{ 
    public float v_mov = 10.0f;
    public bool canMove = true; 


    public void ControlMovimiento ()
    {
        if (canMove == true)
        {
            v_mov = 10.0f;
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
            canMove = !canMove;
        }
    }
    void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
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
    
}