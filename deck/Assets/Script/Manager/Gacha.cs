using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Probability
{
    [Header ("Probability")]
    public float NomalProb;
    public float RareProb;
    public float HeroProb;
    public float LegendProb;
    [Header ("CardNumber")]
    public int NomalCard;
    public int RareCard;
    public int HeroCard;
    public int LegendCard;
}
public class Gacha : MonoBehaviour
{
    public UserData Data;

    public Probability NomalChest = new Probability();
    public Probability GoodChest = new Probability();
    void Awake()
    {
        Data = UserData.instance;
    }

    /// <summary>
    /// 카드 추가해주는 함수입니다. id = 카드 아이디 / Num = 갯수
    /// </summary>
    void AddCard(int id, int Num)
    {

    }
    /// <summary>
    /// 가중치 랜덤 함수입니다. num = 횟수
    /// </summary>
    void WeightRandom(Probability prob, int num)
    {
        for(int i = 0; i < num; i++)
        {
            
        }
    }
}
