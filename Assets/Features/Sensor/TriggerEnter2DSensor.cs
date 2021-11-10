using UnityEngine;
using System;

public class TriggerEnter2DSensor : Sensor // Change "MonoBehaviour" to "Sensor"
{
    /*private void Awake() {
        ObservableTrigger2DTrigger trigger = this.gameObject.AddComponent<ObservableTrigger2DTrigger>();
        SensorTriggered = trigger.OnTriggerEnter2DAsObservable() //IObservable<Collider2D>
            .Select(collider => EventArgs.Empty); //IObservable<EventArgs>
    }*/

    public void OnTriggerEnter2D(Collider2D other)
    {
        OnSensorTriggered(EventArgs.Empty);
    }
    
}