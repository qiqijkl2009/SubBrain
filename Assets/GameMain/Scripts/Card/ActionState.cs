using UnityEngine;

public class ActionState : MonoBehaviour
{
    public GameActionModel Model;
    public GameActionToEvent GameActionOverride;
    public object[] GameActionOverrideArgs;

    public void InitByGameActionCreator(GameActionCreator gameAction)
    {
        Model = gameAction.Model;
    }


    public void TakeAction()
    {
        if (GameActionOverride is not null)
        {
            var gameEvent = GameActionOverride.Invoke(gameObject);
            ManagerVariant.CreateGameEvent(gameEvent);
        }
        else
        {
            var gameEvent = Model.GameAction.Invoke(gameObject);
            ManagerVariant.CreateGameEvent(gameEvent);
        }

        ManagerVariant.RoundOver();
    }
}