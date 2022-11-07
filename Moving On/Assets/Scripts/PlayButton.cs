using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Animator transition;
    public void PlayButtonScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play the animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(0);
        //Then the load the scene
        SceneManager.LoadScene(levelIndex);
    }
}
