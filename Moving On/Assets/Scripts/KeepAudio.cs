using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepAudio : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

     void Update()
    {
        Scene activeScene = SceneManager.GetActiveScene();

        string activeName = activeScene.name;

        if(activeName == "Round1Scene")
        {
            Destroy(this.gameObject);
        }
    }

}
