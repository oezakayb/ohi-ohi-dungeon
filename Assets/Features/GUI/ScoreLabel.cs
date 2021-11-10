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
    
    public void OnEnable()
    {
        GameData.Instance.ScoreUpdated += ScoreChanged;
    }
    
    public void OnDisable()
    {
        GameData.Instance.ScoreUpdated -= ScoreChanged;
    }

    public void UpdateText(int score)
    {
        _text.text = score.ToString();
    }

    public void ScoreChanged(object sender, int args)
    {
        UpdateText(args);
    }
}