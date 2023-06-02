using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckSlot : MonoBehaviour
{
    public CardData SelectCard;

    public Button CardChangeBtn;
    
    public Image cardImage;
    public Text cardName;

    void Start()
    {
        CardChangeBtn.onClick.AddListener(() => ChangeCard());
    }

    void Update()
    {

    }

    void ChangeCard()
    {
        DeckManager.instance.ChangeDeck = this;
        DeckManager.instance.SelectPanel.gameObject.SetActive(true);
    }
    public void SetCard()
    {
        cardImage.sprite = SelectCard.CardSprite;
        cardName.text = SelectCard.CardName;
    }
}
