using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Input_Manager controls;
    [SerializeField] private float speed = 5;
    [SerializeField] List<Item> itens = new List<Item>();

    Dictionary<Coin.CurrencyTypes, int> coins = new Dictionary<Coin.CurrencyTypes, int>();
    public bool interacting = false;

    void Awake()
    {
        controls = new Input_Manager();

        for(int i=0;i<5;i++)
        {
            Coin c = ScriptableObject.CreateInstance<Coin>();
            c.currencyType = (Coin.CurrencyTypes)i;
            coins.Add(c.currencyType, 0);
        }
    }

    void Update()
    {
        float movement = controls.Player.Movement.ReadValue<float>();

        Vector3 currentPos = transform.position;
        currentPos.x += movement * speed * Time.deltaTime;
        transform.position = currentPos;
    }

    void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            interacting = true;
        else if (ctx.canceled)
            interacting = false;
    }
    public void AddItemToBag(Item newItem)
    {
        itens.Add(newItem);
        UI_Items.instance.AddItemToUI(newItem);
    }
    public void AddCurrency(Coin.CurrencyTypes currencyType, int amount)
    {
        coins[currencyType] += amount;
        UI_Coins.instance.Change_UI_Currency(currencyType);
    }
    public float GetCurrency(Coin.CurrencyTypes currencyType)
    {
        return coins[currencyType];
    }

    private void OnEnable()
    {
        controls.Player.Interact.started += Interact;
        controls.Player.Interact.canceled += Interact;
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Interact.started -= Interact;
        controls.Player.Interact.canceled -= Interact;
        controls.Disable();
    }
}