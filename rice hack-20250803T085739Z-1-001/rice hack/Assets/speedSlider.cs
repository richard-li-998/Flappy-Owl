using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeedController : MonoBehaviour
{
    public Slider speedSlider;
    
    private void Start()
    {
        speedSlider.onValueChanged.AddListener(ChangeGameSpeed);
    }

    private void ChangeGameSpeed(float value)
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = speedSlider.value;
        }
    }
}