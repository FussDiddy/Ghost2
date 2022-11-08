using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningLogoSceneAdvancer : MonoBehaviour
{

    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveToNextRound(sceneNumber));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveToNextRound(int level)
    {
        //Wait
        yield return new WaitForSeconds(6);
        //Then the load the scene
        SceneManager.LoadScene(level);
    }
}
