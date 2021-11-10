using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDownSensor : Sensor, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData) {
        SensorEventArgs eventArgs = new SensorEventArgs(eventData);
        OnSensorTriggered(eventArgs);
    }
}
