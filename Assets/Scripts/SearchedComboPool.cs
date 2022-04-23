using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "SearchedComboPool", menuName = "SearchedComboPool", order = 0)]
public class SearchedComboPool : ScriptableObject
{
    private static System.Random rnd = new();

    [SerializeField] private int inputs;
    [SerializeField] private List<string> pool = new();

    public string GetSearchedCombo()
    {
        var tempPool = new List<string>(this.pool);
        var queue = new Queue<string>(tempPool.OrderBy(s => rnd.Next()));
        var result = string.Empty;
        for (var i = 0; i < this.inputs; i++)
        {
            result += queue.Dequeue();
        }

        return result;
    }
}