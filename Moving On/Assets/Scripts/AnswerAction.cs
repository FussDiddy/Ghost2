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
            //Play right answer animation
            OppossumAnimator.instance.AnswerRight(true);

            //Play correct answer audio clip
            FindObjectOfType<SFXManager>().Play("CorrectAnswer");
        }

        if (answerCorrect == false)
        {
            //Wrong answer animation
            OppossumAnimator.instance.AnswerWrong(true);

            //Play correct answer audio clip
            FindObjectOfType<SFXManager>().Play("WrongAnswer");
        }

        if (npc1AnswerCorrect == true)
        {
            //Update score
            NPC1ScoreManager.instance.AddNPC1Points(questionWorth);
            //Play animation
            RaccoonAnimator.instance.AnswerRight(true);
        }

        if (npc1AnswerCorrect == false)
        {
            //Wrong answer animation
            RaccoonAnimator.instance.AnswerWrong(true);
        }

        if (npc2AnswerCorrect == true)
        {
            //Update score
            NPC2ScoreManager.instance.AddNPC2Points(questionWorth);
            //Play animation
            MouseAnimator.instance.AnswerRight(true);
        }

        if (npc2AnswerCorrect == false)
        {
            //Wrong answer animation
            MouseAnimator.instance.AnswerWrong(true);
        }

        if (npc3AnswerCorrect == true)
        {
            //Update score
            NPC3ScoreManager.instance.AddNPC3Points(questionWorth);
            //Play animation
            SkunkAnimator.instance.AnswerRight(true);
        }

        if (npc3AnswerCorrect == false)
        {
            //Wrong answer animation
            SkunkAnimator.instance.AnswerWrong(true);
        }

        if (npc4AnswerCorrect == true)
        {
            //Update score
            NPC4ScoreManager.instance.AddNPC4Points(questionWorth);
            //Play animation
            CoyoteAnimator.instance.AnswerRight(true);
        }

        if (npc4AnswerCorrect == false)
        {
            //Wrong answer animation
            CoyoteAnimator.instance.AnswerWrong(true);
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
