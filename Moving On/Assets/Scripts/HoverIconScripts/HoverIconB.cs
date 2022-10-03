using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverIconB : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowIconB();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverManagerB.OnMouseLoseFocusB();
    }

    private void ShowIconB()
    {
        HoverManagerB.OnMouseHoverB();
    }

}
