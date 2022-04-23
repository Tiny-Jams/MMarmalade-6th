using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using com.tinyjams.tjlib.Runtime.Utility.ComboSystem;
using com.tinyjams.tjlib.Runtime.Utility.Extensions;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private string menuSceneName = "Menu";
    [SerializeField] private UnityEvent onStartNextRoundBeforeDelay = new();
    [SerializeField] private UnityEvent onStartNextRound = new();
    [SerializeField] private UnityEvent onRoundEnded = new();
    [SerializeField] private UnityEvent<string> onInputReceived = new();
    [SerializeField] private UnityEvent onRoundEndedAfterDelay = new();
    [SerializeField] private UnityEvent onGameOver = new();
    [SerializeField] private List<SearchedComboPool> searchedComboPools = new();
    [SerializeField] private float maxRoundTime = 5.0f;
    [SerializeField] private float preRoundWaitTime = 1.0f;
    [SerializeField] private float roundWaitTime = 1.0f;
    [SerializeField] private float postRoundWaitTime = 1.0f;
    [SerializeField] private RoundTimerUI roundTimerUI;

    [Header("Score Calculation")]
    [SerializeField] private float timeModifierMin = 1.0f;

    [SerializeField] private float timeModifierMax = 2.0f;
    [SerializeField] private float pointsPerCorrectSlot = 1.0f;
    [SerializeField] private float pointsPerCorrectAmount = 1.0f;

    private PlayerInput input;
    private int currentRound = -1;
    private bool roundActive = false;
    private string searchedCombo = string.Empty;
    private string currentResultInput = string.Empty;
    private float gameScore;
    private readonly List<char> inputOptions = new() { 'U', 'R', 'D', 'L' };

    public float CurrentRoundTime { get; private set; } = 0.0f;

    private void Awake()
    {
        this.input = new PlayerInput();
        this.gameScore = 0.0f;
    }

    private void OnEnable()
    {
        this.input.General.Enable();
    }

    private void OnDisable()
    {
        this.input.General.Disable();
    }

    private void Start()
    {
        this.input.General.Exit.started += this.OnExit;
        this.input.General.Up.started += context => this.OnComboInput("U");
        this.input.General.Right.started += context => this.OnComboInput("R");
        this.input.General.Down.started += context => this.OnComboInput("D");
        this.input.General.Left.started += context => this.OnComboInput("L");

        this.StartCoroutine(this.StartNextRound());
    }

    private void OnComboInput(string s)
    {
        if (!this.roundActive) return;

        this.currentResultInput += s;
        this.onInputReceived.Invoke(s);

        if (this.currentResultInput.Length >= this.searchedCombo.Length)
        {
            this.EndRound();
            this.CurrentRoundTime = this.maxRoundTime;
        }
    }

    private void OnExit(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(this.menuSceneName);
    }

    private IEnumerator StartNextRound()
    {
        this.onStartNextRoundBeforeDelay.Invoke();
        
        this.roundTimerUI.UpdateValue(0.0f);
        
        yield return new WaitForSeconds(this.preRoundWaitTime);
        this.currentRound++;
        if (this.currentRound >= this.searchedComboPools.Count)
        {
            // All rounds played
            this.GameOver();
            yield break;
        }

        this.searchedCombo = this.searchedComboPools[this.currentRound].GetSearchedCombo();
        this.CurrentRoundTime = 0.0f;
        this.roundActive = true;
        this.currentResultInput = string.Empty;
        this.onStartNextRound.Invoke();

        this.StartCoroutine(this.RoundRoutine());
    }

    private void GameOver()
    {
        ScoreManager.Score = this.gameScore;
        this.onGameOver.Invoke();
    }

    private void EndRound()
    {
        if (!this.roundActive) return;

        this.roundActive = false;
        this.gameScore += this.CalculateScore();
        Debug.Log($"Score is now {this.gameScore}");
    }

    private IEnumerator RoundRoutine()
    {
        while (this.CurrentRoundTime < this.maxRoundTime)
        {
            this.CurrentRoundTime += Time.deltaTime;
            this.roundTimerUI.UpdateValue(this.GetTimeInPercentage());
            yield return 0;
        }

        this.EndRound(); // End Round if Time is over
        this.onRoundEnded.Invoke();
        yield return new WaitForSeconds(this.roundWaitTime);
        this.onRoundEndedAfterDelay.Invoke(); // Fade out
        yield return new WaitForSeconds(this.postRoundWaitTime);
        this.StartCoroutine(this.StartNextRound());
    }

    private float CalculateScore()
    {
        var correctSlotAmount = 0;
        var idx = 0;
        while (idx < this.searchedCombo.Length && idx < this.currentResultInput.Length)
        {
            correctSlotAmount += this.searchedCombo[idx].Equals(this.currentResultInput[idx]) ? 1 : 0;
            idx++;
        }

        var timeMod = this.CurrentRoundTime.Remap(this.maxRoundTime, 0.0f, this.timeModifierMin, this.timeModifierMax);

        var correctAmount = (from c in this.inputOptions
            let inputAmount = this.currentResultInput.Count(s => s.Equals(c))
            let searchedAmount = this.searchedCombo.Count(s => s.Equals(c))
            select Mathf.Min(inputAmount, searchedAmount)).Sum();

        return (correctSlotAmount * this.pointsPerCorrectSlot + correctAmount * this.pointsPerCorrectAmount) * timeMod;
    }

    public float GetTimeInPercentage()
    {
        return this.CurrentRoundTime / this.maxRoundTime;
    }
}