using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject NpcExplodePrefab;
    public List<Item> items_Available;
    List<Item> itemsToUIStore;
    bool canOpenStore = false;
    Player player;

    void Update()
    {
        if (canOpenStore && player.interacting)
        {
            Coin_Spawner.instance.StopSpawn();
            UI_Store.instance.OpenStore(itemsToUIStore);
            canOpenStore = false;
        }
    }

    public void RemoveItem(Item itemToRemove)
    {
        items_Available.Remove(itemToRemove);
        if(items_Available.Count == 0)
        {
            Coin_Spawner.instance.enabled = false;
            NpcExplode();
        }
    }

    public void NpcExplode()
    {
        Instantiate(NpcExplodePrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject.GetComponent<Player>();
            canOpenStore = true;

            //min inclusivo - max exclusivo (sorteando de 3 a 5 itens)
            int random = Random.Range(3, 6);
            itemsToUIStore = GetRandomItemsFromList(items_Available, random);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canOpenStore = false;
        }
    }

    public static List<T> GetRandomItemsFromList<T>(List<T> list, int number)
    {
        // lista auxiliar recebida
        List<T> tmpList = new List<T>(list);
        // lista auxiliar a retornar
        List<T> newList = new List<T>();

        // a lista recebida ainda contém elementos?
        while (newList.Count < number && tmpList.Count > 0)
        {
            int index = Random.Range(0, tmpList.Count);
            newList.Add(tmpList[index]);
            tmpList.RemoveAt(index);
        }

        return newList;
    }
}
