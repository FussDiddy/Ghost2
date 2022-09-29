using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour
{
    public Animator transition;
    public void RightAnswer()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play the animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(1);
        //Then the load the scene
        SceneManager.LoadScene(levelIndex);
    }
}
