using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Vector2 direction;
    private Animator anim;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    public Vector2 direccion
    {
        get 
        {
            return direction;
        }
    }
    private void FixedUpdate()
    {
        RUNN();
    }

    void RUNN()
    {
        float H = Input.GetAxisRaw("Horizontal");
        float V = Input.GetAxisRaw("Vertical");
        if (H != 0f || V != 0f)
        {
            direction = new Vector2(H, V).normalized;
            anim.SetBool("semueve", true);
        }
        else 
        {
            anim.SetBool("semueve", false);
        }
        rb2d.velocity = new Vector2(H, V).normalized * speed;


    }



}
