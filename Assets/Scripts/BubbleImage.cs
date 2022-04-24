using System;
using UnityEngine;
using UnityEngine.UI;

public class BubbleImage : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private Sprite correctBgSprite;

    private void Start()
    {
        this.Deselect();
    }

    public void Select()
    {
        this.background.gameObject.SetActive(true);   
    }

    public void SetCorrect()
    {
        this.background.sprite = this.correctBgSprite;
    }
    
    public void Deselect()
    {
        this.background.gameObject.SetActive(false); 
    }
}