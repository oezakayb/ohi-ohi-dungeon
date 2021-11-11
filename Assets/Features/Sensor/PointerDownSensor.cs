using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;
using UniRx.Triggers;

public class PointerDownSensor : Sensor
{
    private void Awake() {
        ObservablePointerDownTrigger trigger = this.gameObject.AddComponent<ObservablePointerDownTrigger>();
        SensorTriggered = trigger.OnPointerDownAsObservable() 
            .Select(e => new SensorEventArgs(e)); //IObservable<EventArgs>
    }
    
    //without UniRx
    /*public void OnPointerDown(PointerEventData eventData) {
        SensorEventArgs eventArgs = new SensorEventArgs(eventData);
        OnSensorTriggered(eventArgs);
    }*/
}
