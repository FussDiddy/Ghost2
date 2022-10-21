using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC1ScoreManager : MonoBehaviour
{
    public static NPC1ScoreManager instance;

    public TMP_Text scoreText;

    public int npc1Score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = npc1Score.ToString();
    }

    //Adds points to the players score based on how many points the question is worth
    public void AddNPC1Points(int points)
    {
        npc1Score += points;
        scoreText.text = npc1Score.ToString();
    }

}
