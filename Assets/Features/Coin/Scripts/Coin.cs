using System;
using UniRx;
using UnityEngine;
using Object = System.Object;

public class Coin : MonoBehaviour
{
    public CoinAnimationController animationController;
    public int value = 1;
    public Sensor sensor;

    private void Awake()
    {
        animationController.PlaySpawnAnimation();
    }

    private void Start()
    {
        sensor.SensorTriggered.Subscribe(CollectSignalDetected)
                            .AddTo(this);
    }

    public void CollectSignalDetected(EventArgs args)
    {
        Collect();
    }

    public void Collect()
    {
        GameData.Instance.IncreaseScore(value);
        animationController.PlayCollectedAnimation();
        Destroy(gameObject, 3.0f);
    }
}