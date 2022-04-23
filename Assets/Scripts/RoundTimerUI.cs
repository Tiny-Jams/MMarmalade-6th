using System;
using UnityEngine;
using UnityEngine.UI;

public class RoundTimerUI : MonoBehaviour
{
    private Slider slider;

    private void Awake()
    {
        this.slider = this.GetComponent<Slider>();
    }

    public void UpdateValue(float timePercentage)
    {
        this.slider.value = Mathf.Clamp01(1.0f - timePercentage);
    }
}