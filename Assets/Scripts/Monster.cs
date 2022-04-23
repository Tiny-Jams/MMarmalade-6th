using System;
using UnityEngine;
using UnityEngine.Events;

public class Monster : MonoBehaviour
{
    [SerializeField] private string upAnimationTriggerName = "Up";
    [SerializeField] private string rightAnimationTriggerName = "Right";
    [SerializeField] private string downAnimationTriggerName = "Down";
    [SerializeField] private string leftAnimationTriggerName = "Left";

    [SerializeField] public UnityEvent onSlammed;

    private Animator animator;

    private void Awake()
    {
        this.animator = this.GetComponent<Animator>();
    }

    public void TriggerAnimation(string s)
    {
        var key = s switch
        {
            "U" => this.upAnimationTriggerName,
            "R" => this.rightAnimationTriggerName,
            "D" => this.downAnimationTriggerName,
            "L" => this.leftAnimationTriggerName,
            _ => ""
        };

        if (this.animator && key != string.Empty)
        {
            this.animator.SetTrigger(key);
        }

        Debug.Log($"SetAnimation to {s}");
    }

    public void SlamDown()
    {
        this.onSlammed.Invoke();
    }
}