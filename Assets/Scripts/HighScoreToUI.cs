using System;
using TMPro;
using UnityEngine;

public class HighScoreToUI : MonoBehaviour
{
    private TMP_Text tmpText;

    private void Awake()
    {
        this.tmpText = this.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        this.tmpText.text = Mathf.RoundToInt(Mathf.Ceil(ScoreManager.HighScore)).ToString();
    }