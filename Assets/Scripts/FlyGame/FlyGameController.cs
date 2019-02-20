using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGameController : MonoBehaviour
{

    private int powerUps;

    void Start()
    {
        powerUps = 0;
    }
    
    public int getPowerUps()
    {
        return powerUps;
    }

    public void setPowerUps(int powerUps)
    {
        this.powerUps = powerUps;
    }
}
