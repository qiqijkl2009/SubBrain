using System.Collections.Generic;
using JKFrame;

public static class CardSystem
{
    private const string SAVE_FILE_NAME = "CardSaveData";
    private static List<string> _unlockCards = new();

    public static void Init()
    {
        _unlockCards = SaveSystem.LoadObject<List<string>>(SAVE_FILE_NAME) ?? _unlockCards;
        EventSystem.AddEventListener("SaveData", Save);
    }

    public static void UnlockCard(string cardId)
    {
        if (!_unlockCards.Contains(cardId))
        {
            _unlockCards.Add(cardId);
        }
    }

    private static void Save()
    {
        SaveSystem.SaveObject(_unlockCards, SAVE_FILE_NAME);
    }
}