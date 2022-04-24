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

    public void UpdateBubble(string s)
    {
        var columns = Mathf.Clamp(s.Length, 1, this.maxColumns);
        var rows = ((s.Length -1) / 4) + 1;

        var width = columns * this.unitPerColumn + this.offset;
        var height = rows * this.unitPerColumn + this.offset;
        this.image.rectTransform.sizeDelta = new Vector2(width, height);

        // remove all old ones
        foreach (Transform child in this.image.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (var prefab in s.Select(c => c switch
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
}