using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGameController : MonoBehaviour
{

    public Timer timer;
    public GameObject gameOver;

    void Update()
    {
        if (timer.time <= 0)
        {
            gameOver.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ramp")
        {
            print("Adding time...");
            timer.time = timer.time + 5f;
        }
    }
}
