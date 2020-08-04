using UnityEngine;

[CreateAssetMenu(fileName = "New Coin", menuName = "Coin")]
public class Coin : ScriptableObject
{
    public Sprite sprite;
    public CurrencyTypes currencyType;
    public enum CurrencyTypes
    {
        blue,
        green,
        white,
        red,
        yellow
    }
}
