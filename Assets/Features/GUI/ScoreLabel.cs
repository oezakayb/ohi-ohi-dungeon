using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;


[RequireComponent(typeof(Text))]
public class ScoreLabel : MonoBehaviour
{
    Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
		GameData.Instance.score
						//.Select(score => string.Format("Score: {0}", score))
						.Subscribe(score => _text.text = "" + score)
						.AddTo(this);
    }
}