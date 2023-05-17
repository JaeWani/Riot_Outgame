using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<CardData> CardList = new List<CardData>();

    private string cardPath = "Card";
    private void Start() 
    {
       CardData[] dataArr = Resources.LoadAll<CardData>(cardPath);
       List<CardData> datalist = new List<CardData>(dataArr);
       CardList = datalist;
    }
}
