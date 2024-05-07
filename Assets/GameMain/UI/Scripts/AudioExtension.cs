using JKFrame;
using UnityEngine;

public static class AudioExtension
{
    private static string[] _uiClick =
    {
        "ui_01",
        "ui_02",
        "ui_03",
    };

    private static string[] _uiSelect =
    {
        "ui_select_card_01",
        "ui_select_card_02",
        "ui_select_card_03",
    };

    public static AudioClip RandomUIClick()
    {
        string id = _uiClick[Random.Range(0, _uiClick.Length)];
        return ResSystem.LoadAsset<AudioClip>(id);
    }
    
    public static AudioClip RandomUISelect()
    {
        string id = _uiSelect[Random.Range(0, _uiSelect.Length)];
        return ResSystem.LoadAsset<AudioClip>(id);
    }
}