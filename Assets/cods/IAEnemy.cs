using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Transform Target;
    public float speed = 3f;
    public float speedOfRotation = 0.0030f;
    //--------------------------------

    public float distanceForShoot = 4f;
    public float distanceForStpo = 2f;   // esta parte del codigo es para que el enemigo me dispare
    public GameObject bulletPrefab;

    public Transform firingPoint;
    public float FireRate;
    private float TimeToShoot;

    //-----------------------------
    private Rigidbody2D rb2d;



    //-----------------------------------------------------

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(shoot());
    }

    private void Update()
    {
        //---------------------------------------------------------------------------------
        if (!Target)
        {
            GetTrget();
        }                        // esta parte del codigo es para que el enemigo gire 
        else
        {
            RotateTowardsTarget();
        }
        //-------------------------------------------------------------------------------

        if (Target != null && Vector2.Distance(Target.position, transform.position) <= distanceForStpo)
        {
            shoot();    
        }
    }

    IEnumerator shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(FireRate);
            Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);


        }
    }



    private void FixedUpdate()
    {
        if (Target != null)
        {
            if (Vector2.Distance(Target.position, transform.position) >= distanceForStpo)
            {
                rb2d.velocity = transform.up * speed;
            }
            else
            {
                rb2d.velocity = Vector2.zero;
            }
        }
    }


    private void RotateTowardsTarget()
    {
        Vector2 TargetDirection = Target.position - transform.position;
        float angle = Mathf.Atan2(TargetDirection.y, TargetDirection.x) * Mathf.Rad2Deg - 90;
        quaternion Q= Quaternion.Euler(new Vector3(0,0,angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Q, speedOfRotation);
    }

    private void GetTrget()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            Target = GameObject.FindGameObjectWithTag("Player").transform;
        } // el termino "FindObject.. se usa para busrcar al objeto "
    }
}
