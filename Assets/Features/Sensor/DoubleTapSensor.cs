using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
public class DoubleTapSensor : Sensor
{
    private void Awake() {
        ObservablePointerDownTrigger trigger = this.gameObject.AddComponent<ObservablePointerDownTrigger>();
        SensorTriggered = trigger.OnPointerDownAsObservable() 
            .Select(e => new SensorEventArgs(e)); //IObservable<EventArgs>
    }
}
