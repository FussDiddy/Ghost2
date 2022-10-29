using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonAnimator : MonoBehaviour
{

    public static RaccoonAnimator instance;

    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void AnswerWrong(bool raccoonAnswer)
    {
        if(raccoonAnswer == true)
        {
            animator.SetBool("Raccoon_answer_wrong", true);
            StartCoroutine(EndAnimation());
        }
    }

    IEnumerator EndAnimation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Raccoon_answer_wrong", false);
    }
}
