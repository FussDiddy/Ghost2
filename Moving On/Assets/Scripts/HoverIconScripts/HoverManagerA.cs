using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManagerA : MonoBehaviour
{
    public RectTransform hoverIconA;

    public static Action OnMouseHoverA;
    public static Action OnMouseLoseFocusA;

    private void OnEnable()
    {
        OnMouseHoverA += ShowIconA;
        OnMouseLoseFocusA += HideIconA;
    }

    private void OnDisable()
    {
        OnMouseHoverA -= ShowIconA;
        OnMouseLoseFocusA -= HideIconA;
    }

    void Start()
    {
        hoverIconA.gameObject.SetActive(false);
    }

    private void ShowIconA()
    {
        hoverIconA.gameObject.SetActive(true);
    }

    private void HideIconA()
    {
        hoverIconA.gameObject.SetActive(false);
    }
}
