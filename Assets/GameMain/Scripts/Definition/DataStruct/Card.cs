using UnityEngine;

public struct CardModel
{
    public string Id;
    public string Name;
    public string[] Tags;
    public bool IsConsumable;
    public bool MaxConsumeTimes;

    public CardUIInfo UIInfo;

    public CardOnCreate OnCreate;
    public object[] OnCreateArgs;
    public CardOnRemove OnRemove;
    public object[] OnRemoveArgs;
    public CardOnTrigger OnTrigger;
    public object[] OnTriggerArgs;
    public CardOnConsume OnConsume;
    public object[] OnConsumeArgs;
    public CardOnDestroy OnDestroy;
    public object[] OnDestroyArgs;
}

public class CardRecord
{
    public string Id;
    public int Index;
}

public struct CardUIInfo
{
    public string TextureId;
    public string Title;
    public string Content;
}

public delegate void CardOnCreate(GameObject card);

public delegate void CardOnRemove(GameObject card);

public delegate void CardOnTrigger(GameObject card);

public delegate void CardOnConsume(GameObject card);

public delegate void CardOnDestroy(GameObject card);