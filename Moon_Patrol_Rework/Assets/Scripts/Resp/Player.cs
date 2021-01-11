using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Text txtHP;
    CarController carcontroller;

    void Start() 
    {
        carcontroller = GetComponent<CarController>();
    }

    void Update() 
    {
        txtHP.text = carcontroller.PobierzWartoscHP().ToString();
    }
}
