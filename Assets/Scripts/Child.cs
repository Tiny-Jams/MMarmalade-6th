using UnityEngine;
using UnityEngine.Events;

public class Child : AbstractChild
{
    [SerializeField] private UnityEvent onNoFearTriggered;
    [SerializeField] private UnityEvent onLittleFearTriggered;
    [SerializeField] private UnityEvent onBigFearTriggered;

    private static readonly int Fear1 = Animator.StringToHash("Fear1");
    private static readonly int Fear2 = Animator.StringToHash("Fear2");

    public override void Scream(float pAmount, float pSlots)
    {
        base.Scream(pAmount, pSlots);

        switch (pAmount)
        {
            case < 0.2f:
                this.onNoFearTriggered.Invoke();
                break;
            case >= 0.2f when pSlots < 0.9f:
                this.animator.SetBool(Fear1, true);
                this.onLittleFearTriggered.Invoke();
                break;
            default:
                this.onBigFearTriggered.Invoke();
                this.animator.SetBool(Fear2, true);
                break;
        }
    }

    public override void StopScream()
    {
        base.StopScream();
        this.animator.SetBool(Fear1, false);
        this.animator.SetBool(Fear2, false);
    }
}