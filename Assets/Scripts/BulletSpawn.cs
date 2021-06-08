
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bulletobj;

    public float bulletspeed = 1.0f;

    ScoreManager scoreManager;

    public float damage = 100f;

    public float range = 100f;

    public Camera fpsCam;


    // Start is called before the first frame update
    void Start()
    {
        //scoreManager=FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // if (Input.GetMouseButtonDown(0))
        // {
        //    BulletDirection(Vector3.forward);
        // }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Instantiate(Bulletobj, hit.point, Quaternion.LookRotation(hit.normal));
        }

    }

    /*private void BulletDirection(Vector3 direction)
    {
        GameObject bulletref = Instantiate(Bulletobj);

        bulletref.transform.position = transform.position;

        Rigidbody rb = bulletref.GetComponent<Rigidbody>();
       
        rb.velocity =transform.rotation * Vector3.forward * bulletspeed;
    }*/

  
}
