using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverUI : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D customeCursor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(customeCursor, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
