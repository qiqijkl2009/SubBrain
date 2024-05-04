using System;
using JKFrame;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameManager>();
    }

    private void Start()
    {
        InitSystem();
    }
    
    private void InitSystem()
    {
        CardSystem.Init();
    }

    private void OnApplicationQuit()
    {
        EventSystem.EventTrigger("SaveData");
    }
}