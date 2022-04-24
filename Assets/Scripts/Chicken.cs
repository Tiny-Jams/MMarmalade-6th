using UnityEngine;
using UnityEngine.Events;

public class Chicken : AbstractChild
{
    [SerializeField] private UnityEvent onNoFearTriggered;
    [SerializeField] private UnityEvent onLittleFearTriggered;
    [SerializeField] private UnityEvent onBigFearTriggered;
    [SerializeField, Range(0.01f, 1.0f)] private float bigFearMinSlotAmount = 1.0f;

    private static readonly int Fear1 = Animator.StringToHash("Fear1");
    private static readonly int Fear2 = Animator.StringToHash("Fear2");

    public override void Scream(float pAmount, float pSlots)
    {
        base.Scream(pAmount, pSlots);

        switch (pAmount)
        {
            case > 0.0f when pSlots >= this.bigFearMinSlotAmount:
                this.onBigFearTriggered.Invoke();
                this.animator.SetBool(Fear2, true);
                break;
            case > 0.0f:
                this.animator.SetBool(Fear1, true);
                this.onLittleFearTriggered.Invoke();
                break;
            default:
                this.onNoFearTriggered.Invoke();
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