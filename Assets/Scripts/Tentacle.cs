using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Tentacle : MonoBehaviour
{
    [SerializeField] private int minRound = 2;
    [SerializeField] private float percentageToSpawn = 0.5f;
    [SerializeField] private float minAnimSpeed = 0.8f;
    [SerializeField] private float maxAnimSpeed = 1.2f;

    private Animator animator;

    private void Awake()
    {
        this.animator = this.GetComponent<Animator>();
    }

    private void Start()
    {
        this.animator.speed = Random.Range(this.minAnimSpeed, this.maxAnimSpeed);
    }

    public void ActivateWithRandomness(int round)
    {
        var p = Random.Range(0.0f, 1.0f);
        if (p < this.percentageToSpawn && round >= this.minRound)
        {
            this.Activate();
        }
        else
        {
            this.Deactivate();
        }
    }

    public void Activate()
    {
        this.gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        this.gameObject.SetActive(false);
    }
}