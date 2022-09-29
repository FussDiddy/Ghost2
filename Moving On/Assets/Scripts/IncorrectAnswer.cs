using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncorrectAnswer : MonoBehaviour
{
    public void WrongAnswer()
    {
        SceneManager.LoadScene(4);
    }

}
