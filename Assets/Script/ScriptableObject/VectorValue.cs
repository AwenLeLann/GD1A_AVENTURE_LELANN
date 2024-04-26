using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver
{
    [Header("Valeur en game")]
    public Vector2 initialValue;
    [Header("Valeur par defaultau debut")]
    public Vector2 defaultValue;

    public void OnAfterDeserialize(){ 
        initialValue = defaultValue;
    }

    public void OnBeforeSerialize(){

    }
}
