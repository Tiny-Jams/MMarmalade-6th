using System;
using System.Collections;
using System.Collections.Generic;
using com.tinyjams.tjlib.Runtime.Utility.Extensions;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CreepyBackgroundEyes : MonoBehaviour
{
    [SerializeField] private Vector2 idleTimeRange = new Vector2(1.0f, 3.0f);
    [SerializeField] private Vector2 blinkingTimeRange = new Vector2(0.5f, 2.0f);
    [SerializeField] private List<Sprite> idleSprites;
    [SerializeField] private List<Sprite> openSprites;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        this.StartCoroutine(this.EyesAnimation());
    }

    private IEnumerator EyesAnimation()
    {
        while (true)
        {
            // set to idle
            this.spriteRenderer.sprite = this.idleSprites.GetRandomElement();
            var seconds = Random.Range(this.idleTimeRange.x, this.idleTimeRange.y);
            yield return new WaitForSeconds(seconds);

            // set to open
            this.spriteRenderer.sprite = this.openSprites.GetRandomElement();
            seconds = Random.Range(this.blinkingTimeRange.x, this.blinkingTimeRange.y);
            yield return new WaitForSeconds(seconds);
        }
    }
}