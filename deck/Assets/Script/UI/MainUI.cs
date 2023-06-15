using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [Header ("Screen")]
    [SerializeField] RectTransform ScreenRect;
    [SerializeField] Vector3 DeckScreenPos;
    [SerializeField] Vector3 MainScreenPos;
    [SerializeField] Vector3 ShopScreenPos;
    [SerializeField] Vector3 CardManagementScreenPos;
    [SerializeField] Vector3 CurrentScreen;

    [Header ("Button")]
    [SerializeField] Button MainScreenBtn;
    [SerializeField] Button DeckScreenBtn;
    [SerializeField] Button ShopScreenBtn;
    [SerializeField] Button CardManagementBtn;

    private void Awake()
    {
        MainScreenBtn.onClick.AddListener(() => SetScreen(MainScreenPos));
        DeckScreenBtn.onClick.AddListener(() => SetScreen(DeckScreenPos));
        ShopScreenBtn.onClick.AddListener(() => SetScreen(ShopScreenPos));
        CardManagementBtn.onClick.AddListener(() => SetScreen(CardManagementScreenPos));
    }
    private void Start() 
    {
        CurrentScreen = MainScreenPos;
    }
    private void Update() 
    {
        ScreenMotion(5000);
    }
    void ScreenMotion(float speed)
    {
        ScreenRect.anchoredPosition = Vector2.MoveTowards(ScreenRect.anchoredPosition,CurrentScreen,speed * Time.deltaTime);
    }
    void SetScreen(Vector3 ScreenPos)
    {
        CurrentScreen = ScreenPos;
    }
}
