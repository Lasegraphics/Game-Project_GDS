using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FirstButton : MonoBehaviour
{

    ActionType actionType;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
      actionType = GameObject.Find("Manager").GetComponent<ActionType>();
      button = GetComponent<Button>();
      Button btn = button.GetComponent<Button>();
      button.Select();
      btn.onClick.AddListener(TaskOnClick);


    }

    void TaskOnClick()=> actionType.Invoke("SelectScene",2f);
		


 
}
