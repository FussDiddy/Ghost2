using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAction : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject targetPanel;
    public bool answerCorrect;
    public bool npc1AnswerCorrect;
    public bool npc2AnswerCorrect;
    public bool npc3AnswerCorrect;
    public bool npc4AnswerCorrect;
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

        if (npc1AnswerCorrect == true)
        {
            //Update score
            NPC1ScoreManager.instance.AddNPC1Points(questionWorth);
        }

        if (npc2AnswerCorrect == true)
        {
            //Update score
            NPC2ScoreManager.instance.AddNPC2Points(questionWorth);
        }

        if (npc3AnswerCorrect == true)
        {
            //Update score
            NPC3ScoreManager.instance.AddNPC3Points(questionWorth);
        }

        if (npc4AnswerCorrect == true)
        {
            //Update score
            NPC4ScoreManager.instance.AddNPC4Points(questionWorth);
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
