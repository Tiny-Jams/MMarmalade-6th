using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FontFadeLoop : MonoBehaviour
{
    [SerializeField] private AnimationCurve curve;

    private TMP_Text textComponent;
    private Color color;

    private void Awake()
    {
        this.textComponent = this.GetComponent<TMP_Text>();
    }

    private void Start()
    {
        this.color = this.textComponent.color;
    }

    private void Update()
    {
        var tempColor = this.color;
        var duration = this.curve.keys[this.curve.length - 1].time;
        var time = Time.time % duration;
        tempColor.a = this.curve.Evaluate(time);
        this.textComponent.color = tempColor;
    }
}