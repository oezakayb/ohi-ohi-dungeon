using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sensor : MonoBehaviour
{
    //public IObservable<EventArgs> SensorTriggered;
    public event EventHandler SensorTriggered;

    public void OnSensorTriggered(EventArgs eventArgs) {
        SensorTriggered?.Invoke(this, eventArgs);
    }
}
