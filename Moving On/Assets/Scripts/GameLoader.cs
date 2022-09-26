using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLoader : MonoBehaviour
{
    public Animator transition;

    // Update is called once per frame
    void Update()
    {
       if(Input.anyKey)
        {
            LoadLevel();

        }
    }

    public void LoadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
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
