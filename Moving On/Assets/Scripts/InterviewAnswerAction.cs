using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterviewAnswerAction : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject targetPanel;

    public int karmaWorth;

    public CanvasGroup karmaAnswerGroup;

    public bool fadeIn = false;
    public bool fadeOut = false;

    public void ClickAction()
    {

        //Update karma
        KarmaManager.instance.AddKarma(karmaWorth);

        //Fade out
        fadeOut = true;

        //Move to response text
        StartCoroutine("MoveToNextCanvas");

    }

    private void Update()
    {
        if (fadeOut)
        {
            if (karmaAnswerGroup.alpha >= 0)
            {
                karmaAnswerGroup.alpha -= Time.deltaTime * 4;
                if (karmaAnswerGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }

    private void FadeOutAction()
    {


    }

    IEnumerator MoveToNextCanvas()
    {
        yield return new WaitForSeconds(1);
        currentPanel.SetActive(false);
        targetPanel.SetActive(true);
    }
}
