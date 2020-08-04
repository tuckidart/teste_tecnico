using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_Store : MonoBehaviour
{
    private Input_Manager controls;
    public static UI_Store instance;
    public GameObject StoreItemPrefab;
    public GameObject itemsPanel;
    public GameObject selectionPrefab;
    List<GameObject> items = new List<GameObject>();
    Player player;
    Npc npc;
    GameObject selection;
    int iterator = 0;

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
        selection = Instantiate(selectionPrefab, Vector3.zero, Quaternion.identity);
        selection.transform.SetParent(items[iterator].transform, false);

        gameObject.SetActive(true);
        player.controls.Disable();
    }

    public void CloseStore()
    {
        gameObject.SetActive(false);
        Destroy(selection);
        foreach (Transform child in itemsPanel.transform)
        {
            items.Remove(child.gameObject);
            Destroy(child.gameObject);
        }
        Coin_Spawner.instance.StartSpawn();
        player.controls.Enable();
        iterator = 0;
    }

    void ChangeSelection(InputAction.CallbackContext context)
    {
        iterator += (int)context.ReadValue<float>();
        if (iterator > items.Count - 1)
            iterator = 0;
        else if (iterator < 0)
            iterator = items.Count - 1;

        selection.transform.SetParent(items[iterator].transform, false);
    }
    void TryBuy(InputAction.CallbackContext context)
    {
        GameObject go = items[iterator];
        Item i = go.GetComponent<Item_Display>().GetItem();
        if(player.GetCurrency(i.coin.currencyType) >= i.value)
        {
            player.AddCurrency(i.coin.currencyType, -i.value);
            player.AddItemToBag(i);
            npc.RemoveItem(i);
            selection.transform.SetParent(null, false);
            items.Remove(go);
            Destroy(go);
            if (items.Count > 0)
            {
                iterator = 0;
                selection.transform.SetParent(items[iterator].transform, false);
            }
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
        controls.Store.ChangeSelection.performed += ChangeSelection;
        controls.Store.Confirm.started += TryBuy;
        controls.Store.Cancel.started += Cancel;
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Store.ChangeSelection.performed -= ChangeSelection;
        controls.Store.Confirm.started -= TryBuy;
        controls.Store.Cancel.started -= Cancel;
        controls.Disable();
    }
}
