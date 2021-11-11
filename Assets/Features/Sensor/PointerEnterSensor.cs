using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;
using UniRx.Triggers;

public class PointerEnterSensor : Sensor
{
    
    private void Awake() {
        ObservablePointerEnterTrigger trigger = this.gameObject.AddComponent<ObservablePointerEnterTrigger>();
        SensorTriggered = trigger.OnPointerEnterAsObservable() 
            .Select(e => new SensorEventArgs(e)); //IObservable<EventArgs>
    }

    //without UniRx 
    /*public void OnPointerEnter(PointerEventData eventData)
    {
        SensorEventArgs eventArgs = new SensorEventArgs(eventData);
        OnSensorTriggered(eventArgs);
    }*/ 
}
