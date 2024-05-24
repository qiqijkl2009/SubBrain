using JKFrame;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static bool IsActionCardMoving;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameManager>();
    }

    private void Start()
    {
        StartGame();
        IsActionCardMoving = false;
    }

    /// <summary>
    /// 开始游戏并初始化第一个回合
    /// </summary>
    public static void StartGame()
    {
        AudioSystem.PlayBGAudio(R.Audio.InGame);
        
        ManagerVariant.CreateGameEvent(DataTable.GameEvent.Data["WakeUp"]);
        ManagerVariant.RoundStart();
    }

    /// <summary>
    /// 结束游戏并进行结算
    /// </summary>
    public static void GameOver()
    {
    }
}