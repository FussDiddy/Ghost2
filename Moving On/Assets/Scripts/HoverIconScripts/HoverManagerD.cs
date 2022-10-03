using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManagerD : MonoBehaviour
{
    public RectTransform hoverIconD;

    public static Action OnMouseHoverD;
    public static Action OnMouseLoseFocusD;

    private void OnEnable()
    {
        OnMouseHoverD += ShowIconD;
        OnMouseLoseFocusD += HideIconD;
    }

    private void OnDisable()
    {
        OnMouseHoverD -= ShowIconD;
        OnMouseLoseFocusD -= HideIconD;
    }

    void Start()
    {
        hoverIconD.gameObject.SetActive(false);
    }

    private void ShowIconD()
    {
        hoverIconD.gameObject.SetActive(true);
    }

    private void HideIconD()
    {
        hoverIconD.gameObject.SetActive(false);
    }
}
