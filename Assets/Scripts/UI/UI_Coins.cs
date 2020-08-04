using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Coins : MonoBehaviour
{
    public static UI_Coins instance;
    public Text[] currencyText;
    public static Player player;

    void Awake()
    {
        instance = this;
        player = GameObject.FindObjectOfType<Player>();
    }

    public void Change_UI_Currency(Coin.CurrencyTypes currency)
    {
        currencyText[(int)currency].text = "x " + player.GetCurrency(currency).ToString();
    }
}