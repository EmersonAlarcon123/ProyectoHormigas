using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed;
    private float destroyobj = 2f;

    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void proyectil(Vector2 direccion)
    {
        rb2d.velocity = direccion * speed;

        Destroy(gameObject, destroyobj);
    }

    private void OnTriggerEnter2D(Collider2D collision) 

    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}

       

    
    

