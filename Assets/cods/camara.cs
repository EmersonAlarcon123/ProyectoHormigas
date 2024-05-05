using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            Vector3 temporalPosition = transform.position;
            temporalPosition.x = player.transform.position.x;
            temporalPosition.y = player.transform.position.y;
            transform.position = temporalPosition;
        }
    }
}
