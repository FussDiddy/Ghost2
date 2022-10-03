using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverIconD : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowIconD();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverManagerD.OnMouseLoseFocusD();
    }

    private void ShowIconD()
    {
        HoverManagerD.OnMouseHoverD();
    }

}
