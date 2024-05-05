using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHeart : MonoBehaviour
{
    [SerializeField] private float vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            vida -= 1;
            if(vida == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
