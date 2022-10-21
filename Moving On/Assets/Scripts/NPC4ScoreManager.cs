using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC4ScoreManager : MonoBehaviour
{
    public static NPC4ScoreManager instance;

    public TMP_Text scoreText;

    public int npc4Score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = npc4Score.ToString();
    }

    //Adds points to the players score based on how many points the question is worth
    public void AddNPC4Points(int points)
    {
        npc4Score += points;
        scoreText.text = npc4Score.ToString();
    }

}
