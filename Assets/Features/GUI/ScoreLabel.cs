using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreLabel : MonoBehaviour
{
    Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    public void UpdateText(int score)
    {
        _text.text = score.ToString();
    }

    public void ScoreChanged(object sender, int args)
    {
        GameData.Instance.ScoreUpdated += ScoreChanged;
        UpdateText(args);
        GameData.Instance.ScoreUpdated -= ScoreChanged;
    }
}