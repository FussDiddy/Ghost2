using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectManager : MonoBehaviour, ISelectHandler, IDeselectHandler
{

    public RectTransform hoverIconA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        ShowIconA();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        HideIcon();
    }

    private void ShowIconA()
    {
        hoverIconA.gameObject.SetActive(true);
    }

    private void HideIcon()
    {
        hoverIconA.gameObject.SetActive(false);
    }
}
