using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerC : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private float velocidad;
    private Vector2 direccion;
    
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
}
