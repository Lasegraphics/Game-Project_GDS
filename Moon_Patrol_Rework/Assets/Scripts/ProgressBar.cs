using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform End;
    [SerializeField] Slider slider;

    float maxDistance;

    void Start()
    {
        maxDistance = GetDistance();
    }

    void Update()
    {
        if (Player.position.x <= maxDistance && Player.position.x <= End.position.x)
        {
            float distance = 1 - (GetDistance()/maxDistance);
            setProgress (distance);
        }
    }

    float GetDistance()
    {
        return Vector2.Distance (Player.position, End.position);
    }

    void setProgress(float p)
    {
        slider.value = p;
    }
}
