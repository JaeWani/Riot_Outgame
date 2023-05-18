#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Gacha))]
public class GachaEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Probability nomal = new Probability();
        nomal.NomalProb = 70;
        nomal.RareProb = 20;
        nomal.HeroProb = 9.5f;
        nomal.LegendProb = 0.5f;

        Probability Good = new Probability();
        Good.NomalProb = 50;
        Good.RareProb = 35;
        Good.HeroProb = 14;
        Good.LegendProb = 1;
        if(GUILayout.Button("희귀도 랜덤")) (target as Gacha).RarityRandom(nomal);
        if(GUILayout.Button("캐릭 뽑기 (기본 상자)")) (target as Gacha).RandomCard((target as Gacha).RarityRandom(nomal));
        if(GUILayout.Button("캐릭 뽑기 (좋은 상자)")) (target as Gacha).RandomCard((target as Gacha).RarityRandom(Good));

        base.OnInspectorGUI();
        serializedObject.ApplyModifiedProperties();
    }
}
#endif