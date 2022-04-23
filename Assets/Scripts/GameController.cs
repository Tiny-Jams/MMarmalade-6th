using System;
using System.Collections;
using System.Collections.Generic;
using com.tinyjams.tjlib.Runtime.Utility.ComboSystem;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private string menuSceneName = "Menu";
    [SerializeField] private UnityEvent onNewRoundInitialized = new();
    [SerializeField] private UnityEvent onRoundEnded = new();
    [SerializeField] private UnityEvent onGameOver = new();
    [SerializeField] private List<SearchedComboPool> searchedComboPools = new();
    [SerializeField] private float maxRoundTime = 5.0f;
    [SerializeField] private float timeModifierMin = 1.0f;
    [SerializeField] private float timeModifierMax = 2.0f;
    [SerializeField] private float preRoundWaitTime = 1.0f;
    [SerializeField] private float postRoundWaitTime = 1.0f;

    private PlayerInput input;
    private int currentRound = -1;
    private bool roundActive = false;
    private string searchedCombo = string.Empty;
    private string currentResultInput = string.Empty;
    private float gameScore;

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

        if (this.currentResultInput.Length >= this.searchedCombo.Length)
        {
            this.CurrentRoundTime = this.maxRoundTime;
            this.EndRound();
        }
    }

    private void OnExit(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(this.menuSceneName);
    }

    private IEnumerator StartNextRound()
    {
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
        this.onNewRoundInitialized.Invoke();

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
            yield return 0;
        }

        this.EndRound(); // End Round if Time is over
        this.onRoundEnded.Invoke(); // Fade out
        yield return new WaitForSeconds(this.postRoundWaitTime);
        this.StartCoroutine(this.StartNextRound());
    }

    private float CalculateScore()
    {
        return 1.0f;
    }
}