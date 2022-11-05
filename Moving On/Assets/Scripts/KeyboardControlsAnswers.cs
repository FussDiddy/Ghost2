using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KeyboardControlsAnswers : MonoBehaviour
{

    public GameObject firstAnswerSelected;


    // Start is called before the first frame update
    void Start()
    {
        FirstSelected();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FirstSelected()
    {
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set a new selected object
        EventSystem.current.SetSelectedGameObject(firstAnswerSelected);

    }
}
