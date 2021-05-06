using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBricks : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    
    void Update()
    {
        TimetoFire();
    }

    void TimetoFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
