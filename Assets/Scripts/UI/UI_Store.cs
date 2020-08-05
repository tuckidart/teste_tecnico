using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class UI_Store : MonoBehaviour
{
    private Input_Manager controls;
    public static UI_Store instance;
    public GameObject StoreItemPrefab;
    public GameObject itemsPanel;
    List<GameObject> items = new List<GameObject>();
    Player player;
    Npc npc;

    void Awake()
    {
        controls = new Input_Manager();
        instance = this;
        player = GameObject.FindObjectOfType<Player>();
        npc = GameObject.FindObjectOfType<Npc>();
        gameObject.SetActive(false);
    }

    public void OpenStore(List<Item> newItems)
    {
        for(int i=0;i<newItems.Count;i++)
        {
            GameObject aux;
            aux = Instantiate(StoreItemPrefab, Vector3.zero, Quaternion.identity);
            aux.transform.SetParent(itemsPanel.transform, false);
            aux.GetComponent<Item_Display>().SetItem(newItems[i]);
            items.Add(aux);
        }

        gameObject.SetActive(true);
        player.controls.Disable();

        EventSystem.current.SetSelectedGameObject(items[0]);
    }

    public void CloseStore()
    {
        gameObject.SetActive(false);
        foreach (Transform child in itemsPanel.transform)
        {
            items.Remove(child.gameObject);
            Destroy(child.gameObject);
        }
        Coin_Spawner.instance.StartSpawn();
        player.controls.Enable();
    }

    void TryBuy(InputAction.CallbackContext context)
    {
        GameObject go = EventSystem.current.currentSelectedGameObject;
        Item i = go.GetComponent<Item_Display>().GetItem();
        if (player.GetCurrency(i.coin.currencyType) >= i.value)
        {
            player.AddCurrency(i.coin.currencyType, -i.value);
            player.AddItemToBag(i);
            npc.RemoveItem(i);
            items.Remove(go);
            Destroy(go);
            if (items.Count > 0)
                EventSystem.current.SetSelectedGameObject(items[0]);
            else
                CloseStore();
        }
    }
    void Cancel(InputAction.CallbackContext context)
    {
        CloseStore();
    }

    private void OnEnable()
    {
        controls.Store.Confirm.started += TryBuy;
        controls.Store.Cancel.started += Cancel;
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Store.Confirm.started -= TryBuy;
        controls.Store.Cancel.started -= Cancel;
        controls.Disable();
    }
}
