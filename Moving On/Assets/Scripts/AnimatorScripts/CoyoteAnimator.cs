using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteAnimator : MonoBehaviour
{

    public static CoyoteAnimator instance;

    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void AnswerWrong(bool coyoteAnswer)
    {
        if (coyoteAnswer == true)
        {
            animator.SetBool("Coyote_answer_wrong", true);
            StartCoroutine(EndWrongAnimation());
        }
    }

    public void AnswerRight(bool coyoteAnswer)
    {
        if (coyoteAnswer == true)
        {
            animator.SetBool("Coyote_answer_right", true);
            StartCoroutine(EndRightAnimation());
        }
    }


    IEnumerator EndWrongAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Coyote_answer_wrong", false);
    }

    IEnumerator EndRightAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Coyote_answer_right", false);
    }
}
