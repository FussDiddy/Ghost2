using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour
{
    public void RightAnswer()
    {
        SceneManager.LoadScene(3);
    }
}
