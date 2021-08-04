using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : MonoBehaviour
{

    ObjectPool myPool;
    public float moveSpeed, lifeTimer, xRange;
    private float currentTimer, xMove;

    public void Spawn(ObjectPool pool)
    {
        myPool = pool;
        currentTimer = 0;
        xMove = Random.Range(-xRange, xRange);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimer < lifeTimer)
        {
            transform.Translate(xMove * Time.deltaTime, moveSpeed * Time.deltaTime, 0);
            currentTimer += Time.deltaTime;
        }
        else myPool.RemoveOldest();
    }
}
