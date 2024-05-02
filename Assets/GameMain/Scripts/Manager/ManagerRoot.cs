using UnityEngine;


public class ManagerRoot : MonoBehaviour
{
    private ManagerRoot()
    {
    }

    private static ManagerRoot _instance;
    public static Transform RootTransform { get; private set; }

    private void Awake()
    {
        if (_instance != null && _instance != this) 
        {
            Destroy(gameObject);
            return;
        }
        
        _instance = this; 
        RootTransform = transform;
        DontDestroyOnLoad(gameObject);
        Init();
    }

    private void Init()
    {
        GameManager.Init();
        GameEventManager.Init();
        PropManager.Init();
        BuffManager.Init();
        RoundManager.Init();
    }
}