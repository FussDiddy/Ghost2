using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAction : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject targetPanel;

    public void ClickAction()
    {
        currentPanel.SetActive(false);
        targetPanel.SetActive(true);
    }
}
