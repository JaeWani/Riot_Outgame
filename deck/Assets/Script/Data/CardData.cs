using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "CardData", menuName = "Data/CardData", order = 1)]
public class CardData : ScriptableObject
{
    public string CardName;
    public int CardID;
    public int CardLV;
    public int CardAmount;
    public Sprite CardSprite;
    public Rarity CardRarity;
    public Color RarityColor;
}

public enum Rarity
{
    Nomal,
    Rare,
    Hero,
    Legend
}
