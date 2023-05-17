using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "CardData", menuName = "Data/CardData", order = 1)]
public class CardData : ScriptableObject
{
    public string CardName;
    public int CardID;
    public int CardLV;
}
