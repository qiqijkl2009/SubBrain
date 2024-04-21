using System;
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

    private void FixedUpdate()
    {
    }

    private void InitSystem()
    {
        CardSystem.Init();
    }
} 