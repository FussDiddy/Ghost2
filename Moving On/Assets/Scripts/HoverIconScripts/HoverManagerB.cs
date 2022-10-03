using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManagerB : MonoBehaviour
{
    public RectTransform hoverIconB;

    public static Action OnMouseHoverB;
    public static Action OnMouseLoseFocusB;

    private void OnEnable()
    {
        OnMouseHoverB += ShowIconB;
        OnMouseLoseFocusB += HideIconB;
    }

    private void OnDisable()
    {
        OnMouseHoverB -= ShowIconB;
        OnMouseLoseFocusB -= HideIconB;
    }

    void Start()
    {
        hoverIconB.gameObject.SetActive(false);
    }

    private void ShowIconB()
    {
        hoverIconB.gameObject.SetActive(true);
    }

    private void HideIconB()
    {
        hoverIconB.gameObject.SetActive(false);
    }
}
