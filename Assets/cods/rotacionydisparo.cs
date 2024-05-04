using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionydisparo : MonoBehaviour
{
    private Camera cam;
    [SerializeField, Range(1f, 20f)] private float rotation;
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
    }
}
