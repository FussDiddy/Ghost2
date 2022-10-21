using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC3ScoreManager : MonoBehaviour
{
    public static NPC3ScoreManager instance;

    public TMP_Text scoreText;

    public int npc3Score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = npc3Score.ToString();
    }

    //Adds points to the players score based on how many points the question is worth
    public void AddNPC3Points(int points)
    {
        npc3Score += points;
        scoreText.text = npc3Score.ToString();
    }

}
