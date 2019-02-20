using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    public GameObject bullet;
    public float bulletSpeed = 15f;
    public Transform gunPoint;
    public GameObject[] bullets;

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            GameObject projectile = Instantiate(bullet, gunPoint.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        }
    }
}
