using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersAppear : MonoBehaviour
{
    public GameObject answerBox;

    // Start is called before the first frame update
    void Start()
    {
        DisableAnswerPanel();
        
    }

    public void DisableAnswerPanel()
    {
        answerBox.gameObject.SetActive(false);
    }

    IEnumerator AnswerPanelAppear()
    {
        yield return new WaitForSeconds(5);
        answerBox.gameObject.SetActive(true);
    }


}
