using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCard : MonoBehaviour
{
    public Button btn;

    public CardData cardData;

    public Image cardSprite;
    public Text cardName;
    private void Awake()
    {
        btn = GetComponent<Button>();
    }
    void Start()
    {
        if (cardData != null)
        {
            btn.onClick.AddListener(() => Select());
        }
    }
    void Select()
    {
        DeckManager.instance.ChangeDeck.SelectCard = cardData;
        DeckManager.instance.ChangeDeck.SetCard();
        DeckManager.instance.SelectPanel.gameObject.SetActive(false);
        
    }
    public void SetCard()
    {
        cardSprite.sprite = cardData.CardSprite;
        cardName.text = cardData.CardName;
    }
}
