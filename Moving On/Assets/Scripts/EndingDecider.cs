using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDecider : MonoBehaviour
{

    private int _karma;

    public int goodEnding;
    public int badEnding;

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
        _karma = PlayerPrefs.GetInt("Karma");

        if (_karma <= 0)
        {
            ToBadEnding(badEnding);
        }
        else
        {
            ToGoodEnding(goodEnding);
        }
        
    }

    public void ToBadEnding(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ToGoodEnding(int level)
    {
        SceneManager.LoadScene(level);
    }
}
