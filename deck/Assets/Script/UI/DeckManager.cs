using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public List<DeckSlot> DeckSlots = new List<DeckSlot>();
    public List<CardData> AllCards;

    [SerializeField] List<SelectCard> SelectCards = new List<SelectCard>();
    void Start()
    {
        var cardData = Resources.LoadAll<CardData>("Card");
        AllCards = new List<CardData>(cardData);
    }

    void Update()
    {
        
    }
}
