using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update

    ActionType exitAct;
     Button button;
    void Start()
    {
        exitAct = GameObject.Find("Manager").GetComponent<ActionType>();
        button = GetComponent<Button>();
        Button btn = button.GetComponent<Button>();
         button.Select();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()=> Debug.Log ("You have clicked the button!");
}
