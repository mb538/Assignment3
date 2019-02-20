using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerUp : MonoBehaviour
{

    public GameObject powerUp;
    public float movementSpeed = 100f;
    private Vector3 randomPos;
    private Vector3 curPos;
    private IEnumerator coroutine;
    private bool isAlive = true;

    void Start()
    {
        curPos = powerUp.transform.position;
        randomPos = new Vector3(Random.Range(curPos.x - 100.0f, curPos.x + 100.0f), Random.Range(curPos.y - 100.0f, curPos.y + 100.0f), Random.Range(curPos.z - 100.0f, curPos.z + 100.0f));
        coroutine = GeneratePosition();
        StartCoroutine(coroutine);
    }

    void Update()
    {
        if (powerUp.transform.position != randomPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, randomPos, movementSpeed * Time.deltaTime);
        }
    }

    IEnumerator GeneratePosition()
    {
        while (isAlive)
        {
            if (powerUp.transform.position == randomPos)
            {
                yield return new WaitForSeconds(Random.Range(1, 5));
                randomPos = new Vector3(Random.Range(curPos.x - 100.0f, curPos.x + 100.0f), Random.Range(curPos.y - 100.0f, curPos.y + 100.0f), Random.Range(curPos.z - 100.0f, curPos.z + 100.0f));
            }
            yield return null;
        }

    }
}
