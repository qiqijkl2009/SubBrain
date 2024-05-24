using UnityEngine;

///<summary>
///角色的资源类属性，如当前生命值，探索点等
///</summary>
public class CharacterResource
{
    /// <summary>
    /// 当前剩余探索点
    /// </summary>
    public int ExplorePoint;

    public CharacterResource(int explorePoint = 0)
    {
        ExplorePoint = explorePoint;
    }

    public bool Enough(CharacterResource requirement)
    {
        return ExplorePoint >= requirement.ExplorePoint;
    }

    public static CharacterResource operator +(CharacterResource a, CharacterResource b)
    {
        return new CharacterResource
        (
            a.ExplorePoint + b.ExplorePoint
        );
    }

    public static CharacterResource operator -(CharacterResource a, CharacterResource b)
    {
        return a + (-1 * b);
    }

    public static CharacterResource operator *(CharacterResource a, CharacterResource b)
    {
        return new CharacterResource
        (
            a.ExplorePoint + b.ExplorePoint
        );
    }

    public static CharacterResource operator *(CharacterResource a, float b)
    {
        return new CharacterResource
        (
            Mathf.FloorToInt(a.ExplorePoint * b)
        );
    }

    public static CharacterResource operator *(float a, CharacterResource b)
    {
        return new CharacterResource
        (
            Mathf.FloorToInt(b.ExplorePoint * a)
        );
    }

    public static readonly CharacterResource None = new();
}