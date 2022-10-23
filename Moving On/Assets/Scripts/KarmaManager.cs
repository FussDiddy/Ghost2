using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarmaManager : MonoBehaviour
{
    public static KarmaManager instance;

    public int karmatotal = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Adds points to the players score based on how many points the question is worth
    public void AddKarma(int karma)
    {
        karmatotal += karma;
    }

}
