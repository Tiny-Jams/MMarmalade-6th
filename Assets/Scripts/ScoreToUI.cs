using System;
using TMPro;
using UnityEngine;

public class ScoreToUI : MonoBehaviour
{
    private TMP_Text tmpText;

    private void Awake()
    {
        tmpText = this.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        this.tmpText.text = Mathf.RoundToInt(Mathf.Ceil(ScoreManager.Score)).ToString();
    }
}