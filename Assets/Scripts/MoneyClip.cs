using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyClip : MonoBehaviour
{
    public ObjectPool moneySpawner;
    public float spawnDelay;
    float currentTimer = 0;
    private void OnMouseDown()
    {
        if (currentTimer > spawnDelay)
        {
            moneySpawner.SpawnRandom(transform.position);
            currentTimer = 0;
        }
        else currentTimer += Time.deltaTime;
    }
}