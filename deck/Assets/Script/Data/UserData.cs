using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SaveData
{
    public List<CardData> SaveCard;
    public List<int> SaveCardLevel;
}
public class UserData : MonoBehaviour
{
    public SaveData saveData;
    private string cardPath = "Card";
    private void Awake()
    {
        for(int i = 0; i < 10; i++)
        saveData.SaveCardLevel.Add(1);

        Load();
        CardData[] dataArr = Resources.LoadAll<CardData>(cardPath);
        if(saveData.SaveCard.Count > 0)
        {
            for(int i = 0; i < dataArr.Length; i++)
            {
                dataArr[i] = saveData.SaveCard[i];
                dataArr[i].CardLV = saveData.SaveCardLevel[i];
                Debug.Log(saveData.SaveCardLevel[i]);
            }
        }
        List<CardData> datalist = new List<CardData>(dataArr);
        saveData.SaveCard = datalist;
    }
    public void Save()
    {
        for(int i = 0; i < saveData.SaveCard.Count; i++)
        {
            saveData.SaveCardLevel[i] = saveData.SaveCard[i].CardLV;
            Debug.Log(saveData.SaveCardLevel[i]);
        }
        var strData = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("Data",strData);
        PlayerPrefs.Save();
    }
    public void Load()
    {
        var strData = PlayerPrefs.GetString("Data");
        JsonUtility.FromJsonOverwrite(strData,saveData);
        Debug.Log(saveData.SaveCard.Count);
    }
}
