using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChildChooser : MonoBehaviour
{
    [SerializeField] private AbstractChild child;
    [SerializeField] private AbstractChild chicken;
    [SerializeField] private float percentageForChicken = 0.2f;

    private AbstractChild activeObj;

    public void Start()
    {
        this.SetRandomChild();
    }

    public void SetRandomChild()
    {
        if (this.activeObj)
        {
            this.StopScream();
        }

        this.chicken.gameObject.SetActive(false);
        this.child.gameObject.SetActive(false);

        var p = Random.Range(0.0f, 1.0f);
        this.activeObj = p <= this.percentageForChicken
            ? this.chicken
            : this.child;

        this.activeObj.gameObject.SetActive(true);
    }

    public void Scream(float pAmount, float pSlots)
    {
        this.activeObj.Scream(pAmount, pSlots);
    }

    public void StopScream()
    {
        this.activeObj.StopScream();
    }
}