#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(UserData))]
public class UserDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Save")) (target as UserData).Save();
        if(GUILayout.Button("Load")) (target as UserData).Load();

        base.OnInspectorGUI();
        serializedObject.ApplyModifiedProperties();
    }
}
#endif