using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public SignalGame thesignal;
    public UnityEvent signalEvent;
    public void OnSignalRaise(){
        signalEvent.Invoke();
    }
    private void OnEnable(){
        thesignal.RegisterListener(this);
    }
    private void OnDisable(){
        thesignal.DeRegisterListener(this);
    }
}
