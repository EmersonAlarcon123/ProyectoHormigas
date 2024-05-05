using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform player;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<player>().transform;
        rb2d = GetComponent<Rigidbody2D>();
        shootEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void shootEnemy()
    {
        Vector2 directionPlayer = (player.position - transform.position).normalized;
        rb2d.velocity = directionPlayer * speed;
        StartCoroutine(destroy());
    }
    IEnumerator destroy()
    {
        float timeForDestroy = 3f;
        yield return new WaitForSeconds(timeForDestroy);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
