﻿using System;
using UnityEngine;
using DyrdaDev.Singleton;
using UniRx;
using Random = System.Random;

public class GameData : SingletonMonoBehaviour<GameData>
{
    public enum LevelTheme
    {
        Demons,
        Undeads,
        Orcs
    }

    public int score;
    public event EventHandler<int> ScoreUpdated; 

    public ReactiveProperty<bool> abilityAvailable = new ReactiveProperty<bool>(false);
   
    [HideInInspector] public LevelTheme currentLevelTheme;
    private Random LevelThemeRandom = new Random();

    public void Awake()
    {
        currentLevelTheme = GetRandomLevelTheme();
    }

    public void IncreaseScore(int value)
    {
        setScore(score + value);
    }

    public void ResetScore()
    {
        setScore(0);
    }

    public int getScore()
    {
        return score;
    }
    
    public void setScore(int score)
    {
        this.score = score;
        ScoreUpdated?.Invoke(this, score);
    }

    public void SetAbilityAvailable(bool value)
    {
        abilityAvailable.Value = value;
    }


    private void GetNextLevelTheme()
    {
        var previousLevelTheme = currentLevelTheme;
        var newLevelTheme = currentLevelTheme;
        
        while (previousLevelTheme == newLevelTheme)
        {
            newLevelTheme = GetRandomLevelTheme();
        }

        currentLevelTheme = newLevelTheme;
    }


    public void Reset()
    {
        ResetScore();
        GetNextLevelTheme();
    }

    private LevelTheme GetRandomLevelTheme()
    {
        Array values = Enum.GetValues(typeof(LevelTheme));
        return (LevelTheme) values.GetValue(LevelThemeRandom.Next(values.Length));
    }
}