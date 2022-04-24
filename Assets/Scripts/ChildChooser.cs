using System;
using UnityEngine;

public class ChildChooser : MonoBehaviour
{
    [SerializeField] private AbstractChild child;
    [SerializeField] private AbstractChild chicken;
    
    private AbstractChild activeObj;

    public void Start()
    {
        this.activeObj = this.child;
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