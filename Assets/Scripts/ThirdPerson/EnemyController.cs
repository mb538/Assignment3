using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float spin = 100f;

    void Update()
    {
        transform.Rotate(Vector3.up, spin * Time.deltaTime);
    }
}
