using UnityEngine;


public class ManagerRoot : MonoBehaviour
{
    [SerializeField] private bool IsSingleton;
    
    private ManagerRoot()
    {
    }

    private static ManagerRoot _instance;
    public static Transform RootTransform { get; private set; }

    private void Awake()
    {
        if (IsSingleton)
        {
            if (_instance != null && _instance != this) 
            {
                Destroy(gameObject);
                return;
            }
        
            DontDestroyOnLoad(gameObject);
        }
        
        _instance = this; 
        RootTransform = transform;
        Init();
    }

    private void Init()
    {
        GameManager.Init();
        GameCardManager.Init();
        PropManager.Init();
        BuffManager.Init();
        RoundManager.Init();
        StatsManager.Init();
    }
}