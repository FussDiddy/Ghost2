using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAction : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject targetPanel;
    public bool answerCorrect;
    public int questionWorth;

    public CanvasGroup answerGroup;

    public bool fadeIn = false;
    public bool fadeOut = false;

    public void ClickAction()
    {
        if(answerCorrect == true)
        {
            //Update score
            ScoreManager.instance.AddPoints(questionWorth);
        }

        fadeOut = true;

        //Move to response text
        StartCoroutine("MoveToNextCanvas");

    }

    private void Update()
    {
        if (fadeOut)
        {
            if (answerGroup.alpha >= 0)
            {
                answerGroup.alpha -= Time.deltaTime * 4;
                if (answerGroup.alpha == 0)
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
