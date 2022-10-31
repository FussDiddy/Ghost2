using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppossumAnimator : MonoBehaviour
{

    public static OppossumAnimator instance;

    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void AnswerWrong(bool oppossumAnswer)
    {
        if (oppossumAnswer == true)
        {
            animator.SetBool("Oppossum_answer_wrong", true);
            StartCoroutine(EndWrongAnimation());
        }
    }

    public void AnswerRight(bool oppossumAnswer)
    {
        if (oppossumAnswer == true)
        {
            animator.SetBool("Oppossum_answer_right", true);
            StartCoroutine(EndRightAnimation());
        }
    }


    IEnumerator EndWrongAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Oppossum_answer_wrong", false);
    }

    IEnumerator EndRightAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Oppossum_answer_right", false);
    }
}