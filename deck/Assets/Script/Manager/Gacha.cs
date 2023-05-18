using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Probability
{
    [Header("Probability")]
    public float NomalProb;
    public float RareProb;
    public float HeroProb;
    public float LegendProb;
    [Header("CardNumber")]
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

    public List<CardBase> Card = new List<CardBase>();
    void Awake()
    {
        Data = UserData.instance;
        ReGacha();
    }
    public void ReGacha()
    {
        StartCoroutine(Gacha());
        IEnumerator Gacha()
        {
            yield return StartCoroutine(GachaMotion(1000));
            foreach(var item in Card)
            {
                CardData Data = RandomCard(RarityRandom(GoodChest));
                item.Name = Data.CardName;
                item.Sprite = Data.CardSprite;
                item.rarity = Data.CardRarity;
                item.SetCard();
            }
        }
    }
    IEnumerator GachaMotion(float speed)
    {
        float RoatateSpeed = 0;
        for(int i = 0; i < 1; i++)
        {
            for(float y = 0; y <= 360; y += Time.deltaTime * RoatateSpeed)
            {
            yield return new WaitForSeconds(0.01f);
            if(RoatateSpeed < speed)
            RoatateSpeed += 1;
            foreach(var item in Card)
            {
                RectTransform tr = item.GetComponent<RectTransform>();
                tr.Rotate(Vector3.up * y);
            }
            }
        }
        foreach(var item in Card)
        {
            RectTransform tr = item.GetComponent<RectTransform>();
            tr.rotation = Quaternion.Euler(0,0,0);
        }
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
    public Rarity RarityRandom(Probability prob)
    {
        float[] probs = new float[4] { prob.NomalProb, prob.RareProb, prob.HeroProb, prob.LegendProb };
        float totalprobs = probs[0] + probs[1] + probs[2] + probs[3];
        float randomValue = Random.value * totalprobs;

        float curValue = 0;
        for(int i = 0; i < 4; i++){
            curValue += probs[i];  
            if(randomValue <= curValue)
            {
                return (Rarity)i;
            }
        }
        return Rarity.Nomal;
    }

    public CardData RandomCard(Rarity rarity)
    {
        int result = Random.Range(0, GetRarity(rarity).Count);
        Debug.Log(GetRarity(rarity)[result].CardName);
        Debug.Log(GetRarity(rarity)[result].CardRarity);
        return GetRarity(rarity)[result];
    }

    /// <summary>
    /// 희귀도에 따른 카드들을 리스트로 반환해주는 함수입니다.
    /// </summary>
    public List<CardData> GetRarity(Rarity rarity)
    {
        var DataArr = Resources.LoadAll<CardData>("Card");
        List<CardData> returnList = new List<CardData>();
        foreach (var item in DataArr)
        {
            if (item.CardRarity == rarity)
            {
                returnList.Add(item);
            }
        }
        return returnList;
    }
}
