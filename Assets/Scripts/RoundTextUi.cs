using System;
using TMPro;
using UnityEngine;

public class RoundTextUi : MonoBehaviour
{
    private TMP_Text tmpText;

    private void Awake()
    {
        this.tmpText = this.GetComponent<TMP_Text>();
    }

    public void UpdateText(int currentRound, int maxRounds)
    {
        this.tmpText.text = $"{currentRound + 1} / {maxRounds}";
    }
}