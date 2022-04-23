using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShake : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration = 1f;
    private Vector3 startPosition;

    public void Shake()
    {
        this.StartCoroutine(this.Shaking());
    }

    private void Start()
    {
        this.startPosition = this.transform.position;
    }

    private IEnumerator Shaking()
    {
        var elapsedTime = 0.0f;

        while (elapsedTime < this.duration)
        {
            elapsedTime += Time.deltaTime;
            var strength = this.curve.Evaluate(elapsedTime / this.duration);
            this.transform.position = this.startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        this.transform.position = this.startPosition;
    }
}