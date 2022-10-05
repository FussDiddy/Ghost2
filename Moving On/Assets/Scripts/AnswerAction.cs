using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAction : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject targetPanel;
    public bool answerCorrect;
    public int questionWorth;

    public void ClickAction()
    {
        if(answerCorrect == true)
        {
            //Update score
            ScoreManager.instance.AddPoints(questionWorth);
        }

        //Move to correct response text
        currentPanel.SetActive(false);
        targetPanel.SetActive(true);
    }
}
