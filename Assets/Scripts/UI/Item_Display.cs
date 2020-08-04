using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_Display : MonoBehaviour
{
    Item item;
    public Text itemName;
    public Image itemImg;
    public Image currencyImage;
    public Text value;

    public void SetItem(Item newItem)
    {
        item = newItem;
        Display();
    }

    void Display()
    {
        itemName.text = item.name;
        itemImg.sprite = item.itemSprite;
        currencyImage.sprite = item.coin.sprite;
        value.text = item.value.ToString() + " X";
    }

    public Item GetItem()
    {
        return item;
    }
}
