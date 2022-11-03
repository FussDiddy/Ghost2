using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkunkAnimator : MonoBehaviour
{

    public static SkunkAnimator instance;

    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void AnswerWrong(bool skunkAnswer)
    {
        if (skunkAnswer == true)
        {
            animator.SetBool("Skunk_answer_wrong", true);
            StartCoroutine(EndWrongAnimation());
        }
    }

    public void AnswerRight(bool skunkAnswer)
    {
        if (skunkAnswer == true)
        {
            animator.SetBool("Skunk_answer_right", true);
            StartCoroutine(EndRightAnimation());
        }
    }


    IEnumerator EndWrongAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Skunk_answer_wrong", false);
    }

    IEnumerator EndRightAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Skunk_answer_right", false);
    }
}
