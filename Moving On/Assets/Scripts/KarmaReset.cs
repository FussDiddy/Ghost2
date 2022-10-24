using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarmaReset : MonoBehaviour
{

    public int karmaReset = 0;

    public int karmaCheck;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Karma", karmaReset);
    }

    // Update is called once per frame
    void Update()
    {
        karmaCheck = PlayerPrefs.GetInt("Karma");
    }
}
