using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuCanvas : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "Game";

    private PlayerInput input;

    private void Awake()
    {
        this.input = new PlayerInput();
    }

    private void OnEnable()
    {
        this.input.General.Enter.Enable();
        this.input.General.Exit.Enable();
    }

    private void OnDisable()
    {
        this.input.General.Enter.Disable();
        this.input.General.Exit.Disable();
    }

    private void Start()
    {
        this.input.General.Enter.started += this.OnEnter;
        this.input.General.Exit.started += this.OnExit;
    }

    private void OnExit(InputAction.CallbackContext context)
    {
        Application.Quit(0);

#if UNITY_EDITOR
        Debug.Log("Application.Quit called, but in Editor nothing will happen!");
#endif
    }

    private void OnEnter(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(this.gameSceneName);
    }
}