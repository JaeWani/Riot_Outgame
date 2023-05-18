using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardBase : MonoBehaviour
{
    [Header ("Set Value")]
    public Image CardSprite;
    public Text CardName;
    public Text CardRarity;
    public Color color;
    [Header ("Input Value")]
    public Sprite Sprite;
    public string Name;
    public Rarity rarity;
    void Start()
    {
    }
    string ReturnRarity(Rarity rarity)
    {
        string returnValue = "";
        switch(rarity)
        {
            case Rarity.Nomal:
            returnValue = "일반";
            color = Color.white;
            break;
            case Rarity.Rare:
            returnValue = "희귀";
            color = new Color(1,0.5f,0,1);
            break;
            case Rarity.Hero:
            returnValue = "영웅";
            color = new Color(1,0,1,1);
            break;
            case Rarity.Legend:
            returnValue = "전설";
            color = Color.cyan;
            break;
        }
        return returnValue;
    }
    public void SetCard()
    {
        CardSprite.sprite = Sprite;
        CardName.text = Name;
        CardRarity.text  = ReturnRarity(rarity);
        CardRarity.color = color;
    }
}
