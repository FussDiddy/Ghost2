using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersAppear : MonoBehaviour
{
    public CanvasGroup answerGroup;

    // Start is called before the first frame update
    void Start()
    {
        DisableAnswerPanel();
        
    }

    //Keeps answer panel hidden until typewriter UI activates it
    public void DisableAnswerPanel()
    {
        answerGroup.alpha = 0;
    }


}
