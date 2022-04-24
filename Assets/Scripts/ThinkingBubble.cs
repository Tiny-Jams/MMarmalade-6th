using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ThinkingBubble : MonoBehaviour
{
    [SerializeField] private int maxColumns = 4;
    [SerializeField] private Image image;
    [SerializeField] private float unitPerColumn = 64;
    [SerializeField] private float offset = 32;

    [SerializeField] private GameObject prefabUp;
    [SerializeField] private GameObject prefabRight;
    [SerializeField] private GameObject prefabDown;
    [SerializeField] private GameObject prefabLeft;

    private string searchedCombo = "";

    public void RemoveOldBubbleImages()
    {
        foreach (Transform child in this.image.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void UpdateBubble(string combo)
    {
        this.searchedCombo = combo;
        var columns = Mathf.Clamp(combo.Length, 1, this.maxColumns);
        var rows = ((combo.Length - 1) / 4) + 1;

        var width = columns * this.unitPerColumn + this.offset;
        var height = rows * this.unitPerColumn + this.offset;
        this.image.rectTransform.sizeDelta = new Vector2(width, height);

        foreach (var prefab in combo.Select(c => c switch
                 {
                     'U' => this.prefabUp,
                     'R' => this.prefabRight,
                     'D' => this.prefabDown,
                     'L' => this.prefabLeft,
                     _ => null
                 }))
        {
            GameObject.Instantiate(prefab, this.image.rectTransform);
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

    public void UpdateInput(string currentResultInput)
    {
        var selectionIdx = currentResultInput.Length;
        for (var childIdx = 0; childIdx < this.image.transform.childCount; childIdx++)
        {
            var child = this.image.transform.GetChild(childIdx);
            string searchedChar = this.searchedCombo[childIdx].ToString();
            string inputChar = currentResultInput.Length <= childIdx
                ? ""
                : currentResultInput[childIdx].ToString();

            if (child.TryGetComponent<BubbleImage>(out var bubbleImage))
            {
                if (childIdx.Equals(selectionIdx))
                {
                    bubbleImage.Select();
                }
                else if (searchedChar.Equals(inputChar))
                {
                    bubbleImage.Select();
                    bubbleImage.SetCorrect();
                }
                else
                {
                    bubbleImage.Deselect();
                }
            }
        }
    }
}