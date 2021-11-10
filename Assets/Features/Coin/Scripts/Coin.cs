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

    public void CollectSignalDetected(object sender, EventArgs args)
    {
        sensor.SensorTriggered += CollectSignalDetected;
        Collect();
        Destroy(sensor.gameObject);
        sensor.SensorTriggered -= CollectSignalDetected;
    }

    public void Collect()
    {
        GameData.Instance.IncreaseScore(value);
        animationController.PlayCollectedAnimation();
        Destroy(gameObject, 3.0f);
    }
}