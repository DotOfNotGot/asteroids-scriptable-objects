using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Variables;

public class EditorManager
{
    
    // Engine

    [SerializeField, Range(0, 10f)] private float _throttlePower;
    [SerializeField, Range(0, 10f)] private float _rotationPower;
    
    [SerializeField] public FloatVariable _throttlePowerObject;
    [SerializeField] public FloatVariable _rotationPowerObject;
    
    // Hull


    [SerializeField] private int _health;
    
    [SerializeField] public IntVariable _healthObject;

    public void AssignValues()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAA");
        _throttlePowerObject.SetValue(_throttlePower);
        _rotationPowerObject.SetValue(_rotationPower);
        _healthObject.SetValue(_health);
    }
    



}
