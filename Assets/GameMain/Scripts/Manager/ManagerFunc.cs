using UnityEngine;

public class ManagerFunc
{
    public static void CreateGameEvent(AddGameEventInfo ageInfo)
    {
        GameEventManager.CreateGameEvent(ageInfo);
    }

    public static void ChangeSceneCard(GameObject card)
    {
        CardManager.ChangeSceneCard(card);
    }
}