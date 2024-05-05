using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float rotation = 0.0030f;
    public float distanceForShoot;
    public float distanceFromStop;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
