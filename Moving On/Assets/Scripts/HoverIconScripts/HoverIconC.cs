using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverIconC : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowIconC();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverManagerC.OnMouseLoseFocusC();
    }

    private void ShowIconC()
    {
        HoverManagerC.OnMouseHoverC();
    }

}
