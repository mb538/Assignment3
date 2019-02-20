using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counter;
    public FlyGameController gc;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        counter.text = gc.getPowerUps().ToString();
        print("Hello from counter");
        print("powerUps: " + gc.getPowerUps());
    }

    public void updateCounter()
    {
        counter.text = gc.getPowerUps().ToString();
        print("counter: " + gc.getPowerUps().ToString());
        animator.Play("TextAnimation");
    }

    private void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            animator.Play("TextAnimation");
        }
    }

}
