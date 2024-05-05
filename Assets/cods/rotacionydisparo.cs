using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionydisparo : MonoBehaviour
{
    private Camera cam;
    [SerializeField, Range(1f, 20f)] private float rotation;

    [SerializeField] private bala bulletPrefab;
    [SerializeField] private Transform shootP;
    [SerializeField] private float timeforshoot;
    [SerializeField] private float timefornextshoot;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direcciones = mousePos - (Vector2)transform.position;
        transform.up = Vector2.MoveTowards(transform.up, direcciones, rotation * Time.deltaTime);
        shoot();
    }
    void shoot()
    {
        if (Input.GetMouseButton(0) && Time.time >= timefornextshoot)
        {
            bala bullet = Instantiate(bulletPrefab,shootP.position,transform.rotation);
            bullet.proyectil(transform.up);
            timefornextshoot = Time.time + timeforshoot;
        }
    }
}
