using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject[] objetos;

    public float timeMin = 1f;
    public float timeMax =2f;   
    // Start is called before the first frame update
    void Start()
    {
        genera();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void genera()
    {
        Instantiate(objetos[Random.Range(0,objetos.Length)],transform.position, Quaternion.identity );
        Invoke("genera", Random.Range(timeMin, timeMax));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
