using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpCoin : MonoBehaviour
{
    public int timeToDestroy = 5;
    public Coin coin;
    bool canGrab = false;
    Player player;

    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        if (canGrab && player.interacting)
        {
            player.AddCurrency(coin.currencyType, 1);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject.GetComponent<Player>();
            canGrab = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canGrab = false;
        }
    }
}