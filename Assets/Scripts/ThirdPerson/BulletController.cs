using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            var expl = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if (bullet != null)
        {
            Destroy(bullet);
        }

    }

}
