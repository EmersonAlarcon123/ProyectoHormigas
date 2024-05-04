using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidajugador : MonoBehaviour
{
    [SerializeField] private float vida;
    public Image barra;
    [SerializeField] private float maxHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barra.fillAmount = vida/maxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy") 
        {
            vida -= 1;
            if (vida <= 0)
            {
                Time.timeScale = 0f;
            }
        }
    }
}
