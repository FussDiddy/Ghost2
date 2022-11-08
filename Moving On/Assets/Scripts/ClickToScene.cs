using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToScene : MonoBehaviour
{

    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickAction()
    {
        ToNextScene(sceneNumber);
    }

    public void ToNextScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
