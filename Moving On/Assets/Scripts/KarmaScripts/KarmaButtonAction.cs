using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarmaButtonAction : MonoBehaviour
{
    
    KarmaDevTool karmaManager;

    // Start is called before the first frame update
    void Start()
    {
        karmaManager = FindObjectOfType<KarmaDevTool>();

        karmaManager.karmaDev = PlayerPrefs.GetInt("Karma");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpClick()
    {
        karmaManager.karmaDev++;
        PlayerPrefs.SetInt("Karma", karmaManager.karmaDev);
    }

    public void DownClick()
    {
        karmaManager.karmaDev--;
        PlayerPrefs.SetInt("Karma", karmaManager.karmaDev);
    }
}
