using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KarmaDevTool : MonoBehaviour
{

    [SerializeField]
    TMP_Text TextKarmaUI;

    private int _karma;


    public int karmaDev
    {
        get { return _karma; }
        set { 
            _karma = value;

            TextKarmaUI.text = karmaDev.ToString();

            PlayerPrefs.SetInt("Karma", karmaDev);
        
            }
    }


    // Start is called before the first frame update
    void Start()
    {
        _karma = PlayerPrefs.GetInt("Karma");
    }



}
