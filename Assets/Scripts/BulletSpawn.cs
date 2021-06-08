
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    //public GameObject Bulletobj;

    public float bulletspeed = 1.0f;

    ScoreManager scoreManager;

    public float damage = 100f;

    public float range = 100f; //ray range

    public Camera fpsCam; //camera reference

    public ParticleSystem muzzleFlash;

    public GameObject impactEffect;


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
        muzzleFlash.Play(); //particle effect of shoot

        RaycastHit hit; //ray variable information storing

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) // shoot raycast starting from camera position to forward direction of cam
        {

            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>(); //enemy health reference of the object raycast is hitting

            if (enemy != null) //if reference is not null
            {
                enemy.TakeDamage(damage); //take damage
            }

            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal)); //particle effect of hit
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
