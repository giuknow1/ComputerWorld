using UnityEngine;
public class Jugador : MonoBehaviour
{ 
    public float v_mov = 10.0f; 

    void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked; 
    }
    
    void Update() 
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