using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Items : MonoBehaviour
{
    public static UI_Items instance;
    public GameObject itemPrefab;
    List<Item> items = new List<Item>();

    void Awake()
    {
        instance = this;
    }

    public void AddItemToUI(Item newItem)
    {
        GameObject aux;
        aux = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
        aux.GetComponentsInChildren<Image>()[1].sprite = newItem.itemSprite;
        aux.transform.SetParent(gameObject.transform, false);
        items.Add(newItem);
    }
}