using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public static DeckManager instance;


    public DeckSlot ChangeDeck;

    public GameObject SelectPanel;

    public List<DeckSlot> DeckSlots = new List<DeckSlot>();
    public List<CardData> AllCards;

    [SerializeField] List<SelectCard> SelectCards = new List<SelectCard>();
    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
        
    }
    void Start()
    {
        var cardData = Resources.LoadAll<CardData>("Card");
        AllCards = new List<CardData>(cardData);

        for(int i = 0; i < AllCards.Count; i++)
        {
            SelectCards[i].cardData = AllCards[i];
            SelectCards[i].SetCard();
        }
    }

    void Update()
    {

    }
}
