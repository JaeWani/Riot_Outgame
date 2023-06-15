using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManagement : MonoBehaviour
{
    [Header ("Card UI")]
    [SerializeField] private Image cardImage;
    [SerializeField] private Text cardName;
    [SerializeField] private Text cardRarity;

    [Header ("Card Info")]
    [SerializeField] private CardData card;
    public CardData Card
    {
        get
        {
            return card;
        }
        set
        {
            card = value;
            Set_CardInfo();
        }
    }
    private void Start() {
        Set_CardInfo();
    }
    private void Set_CardInfo()
    {
        cardImage.sprite = card.CardSprite;
        cardName.text = card.CardName;
        cardRarity.color = card.RarityColor;
        cardRarity.text = ReturnRarity(card.CardRarity);
    }
    private string ReturnRarity(Rarity rarity)
    {
        string result = "";
        switch(rarity)
        {
            case Rarity.Nomal: result = "일반"; break;
            case Rarity.Rare: result = "희귀"; break;
            case Rarity.Hero: result = "영웅"; break;
            case Rarity.Legend: result = "전설"; break;
        }
        return result;
    }
}
