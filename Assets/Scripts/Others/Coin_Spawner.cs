using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public static Coin_Spawner instance;
    public float timeToSpawn = 3;
    public List<GameObject> coins;
    float timer;
    bool canSpawn;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn)
        {
            timer += Time.deltaTime;
            if (timer > timeToSpawn)
            {
                int rand = Random.Range(0, coins.Count);
                Vector3 pos = new Vector3(Random.Range(-5, 5), coins[rand].transform.position.y, coins[rand].transform.position.z);
                Instantiate(coins[rand], pos, Quaternion.identity);
                timer = 0;
            }
        }
    }

    public void StartSpawn()
    {
        timer = 0;
        canSpawn = true;
    }
    public void StopSpawn()
    {
        canSpawn = false;
    }
}
