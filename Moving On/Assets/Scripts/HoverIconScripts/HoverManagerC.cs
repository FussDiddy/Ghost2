using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManagerC : MonoBehaviour
{
    public RectTransform hoverIconC;

    public static Action OnMouseHoverC;
    public static Action OnMouseLoseFocusC;

    private void OnEnable()
    {
        OnMouseHoverC += ShowIconC;
        OnMouseLoseFocusC += HideIconC;
    }

    private void OnDisable()
    {
        OnMouseHoverC -= ShowIconC;
        OnMouseLoseFocusC -= HideIconC;
    }

    void Start()
    {
        hoverIconC.gameObject.SetActive(false);
    }

    private void ShowIconC()
    {
        hoverIconC.gameObject.SetActive(true);
    }

    private void HideIconC()
    {
        hoverIconC.gameObject.SetActive(false);
    }
}
