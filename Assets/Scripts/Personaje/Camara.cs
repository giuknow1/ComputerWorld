using UnityEngine;
public class Camara : MonoBehaviour 
{ 
    Vector2 Mira; 
    Vector2 suavidad; 
    
    public float sensibilidad = 5.0f; 
    public float suavizado = 2.0f; 
    
    public bool control_camara = false;
    public bool controlQ = false;
    
    GameObject jugador; 
    

    public void ActivacionControl()
    {
        if (Input.GetKeyDown(KeyCode.E) && controlQ == false)
        {
            control_camara = !control_camara;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            controlQ = true;
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            controlQ = false;
        }
    }

    void Start() 
    {
       
        jugador = this.transform.parent.gameObject; 
    } 
    
    void Update() 
    {
        ActivacionControl();

        if (control_camara == false)
        {
            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            md = Vector2.Scale(md, new Vector2(sensibilidad * suavizado, sensibilidad * suavizado));
            suavidad.x = Mathf.Lerp(suavidad.x, md.x, 1f / suavizado);
            suavidad.y = Mathf.Lerp(suavidad.y, md.y, 1f / suavizado);
            Mira += suavidad; Mira.y = Mathf.Clamp(Mira.y, -90f, 90f);
            transform.localRotation = Quaternion.AngleAxis(-Mira.y, Vector3.right);
            jugador.transform.localRotation = Quaternion.AngleAxis(Mira.x, jugador.transform.up);
        }
    } 
}