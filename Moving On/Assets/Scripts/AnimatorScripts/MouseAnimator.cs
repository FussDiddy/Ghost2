using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAnimator : MonoBehaviour
{

    public static MouseAnimator instance;

    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void AnswerWrong(bool mouseAnswer)
    {
        if (mouseAnswer == true)
        {
            animator.SetBool("Mouse_answer_wrong", true);
            StartCoroutine(EndWrongAnimation());
        }
    }

    public void AnswerRight(bool mouseAnswer)
    {
        if (mouseAnswer == true)
        {
            animator.SetBool("Mouse_answer_right", true);
            StartCoroutine(EndRightAnimation());
        }
    }


    IEnumerator EndWrongAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Mouse_answer_wrong", false);
    }

    IEnumerator EndRightAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Mouse_answer_right", false);
    }
}
