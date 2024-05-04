using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerC : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private float velocidad;
    private Vector2 direccion;

    Vector2 input;
    float rotacion;
    [SerializeField] private bool ismoving;
    [SerializeField] private float anguloRotacion = 0.4f;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        direccion = Vector2.up;
    }
    public Vector2 ondirection
    {
        get
        {
            return direccion;
        }
    }

    // Update is called once per frame
    void Update()
    {
        speed();
       // dameRotacion();
    }

    void speed()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float V = Input.GetAxisRaw("Vertical");


        if (h != 0f || V != 0f)
        {
            direccion = new Vector2(h, V).normalized;
        }
        rb2d.velocity = new Vector2(h, V).normalized * velocidad;

    }
   /* void dameRotacion()
    {
        Vector2 lookDirection = new Vector2(-input.x, input.y);
        if(ismoving)
        {
            direccion.x = Mathf.Atan2(lookDirection.x,lookDirection.y)*Mathf.Rad2Deg;
        }
        if(rb2d.rotation<= -90 && rotacion <= -90)
        {
            rb2d.rotation += 360;
            rb2d.rotation = Mathf.Lerp(rb2d.rotation, rotacion, anguloRotacion);
        }
        else if (rb2d.rotation >= 90 && rotacion <= -90)
        {
            rb2d.rotation -= 360;
            rb2d.rotation = Mathf.Lerp(rb2d.rotation, rotacion, anguloRotacion);
        }
        else
        {
            rb2d.rotation = Mathf.Lerp(rb2d.rotation, rotacion, anguloRotacion);
        }
    }*/
}
