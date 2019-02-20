using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Counter counter;
    public FlyGameController gc;
    private bool collected;

    private void Start()
    {
        collected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (collected = false && other.GetComponent<Collider>().tag == "Player")
        {
            gc.setPowerUps(gc.getPowerUps() + 1);
            print("PowerUp Collected! " + gc.getPowerUps());
            powerUp.SetActive(false);
            collected = true;
        }
        if (collected = false && other.GetComponent<BoxCollider>().tag == "ThePlayer")
        {
            gc.setPowerUps(gc.getPowerUps() + 1);
            print("PowerUp Collected! " + gc.getPowerUps());
            powerUp.SetActive(false);
            collected = true;
        }
        */
        if (this.collected == false)
        {
            gc.setPowerUps(gc.getPowerUps() + 1);
            print("PowerUp Collected! " + gc.getPowerUps());
            counter.updateCounter();
            this.gameObject.SetActive(false);
            this.collected = true;
        }
    }

}
