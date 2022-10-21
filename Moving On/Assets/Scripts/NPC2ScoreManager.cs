using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC2ScoreManager : MonoBehaviour
{
    public static NPC2ScoreManager instance;

    public TMP_Text scoreText;

    public int npc2Score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = npc2Score.ToString();
    }

    //Adds points to the players score based on how many points the question is worth
    public void AddNPC2Points(int points)
    {
        npc2Score += points;
        scoreText.text = npc2Score.ToString();
    }

}
