using JKFrame;
using UnityEngine;

public class AspectRatioFixer : MonoBehaviour
{
    private void Start()
    {
        EventSystem.AddEventListener(GameConstant.ScriptEvent.CHANGE_RESOLUTION, CalculateRatio);

        CalculateRatio();
    }

    private void CalculateRatio()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
        var mainCamera = Camera.main;

        if (sprite == null) return;
        if (mainCamera == null) return;

        float spriteWidth = sprite.bounds.size.x;
        float spriteHeight = sprite.bounds.size.y;
        float viewHeight = mainCamera.orthographicSize * 2;
        float viewWidth = viewHeight * mainCamera.aspect;

        float zoomRatio = Mathf.Max(viewWidth / spriteWidth, viewHeight / spriteHeight);
        transform.localScale = Vector3.one * zoomRatio;
    }
}