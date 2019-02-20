using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timer;
    public float time = 20f;

    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timer.GetComponent<Text>().text = string.Format("Time Left: {0:0.00}", time);
        }
    }
}
