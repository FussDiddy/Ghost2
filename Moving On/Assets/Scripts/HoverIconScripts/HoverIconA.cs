using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverIconA : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowIconA();
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        HoverManagerA.OnMouseLoseFocusA();
    }

    private void ShowIconA()
    {
        HoverManagerA.OnMouseHoverA();
    }


}
