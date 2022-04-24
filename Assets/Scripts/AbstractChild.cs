using System;
using UnityEngine;


    public class AbstractChild : MonoBehaviour
    {
        protected Animator animator;

        protected void Awake()
        {
            this.animator = this.GetComponent<Animator>();
        }

        public virtual void Scream(float pAmount, float pSlots)
        {
            
        }

        public virtual void StopScream()
        {
            
        }
    }
