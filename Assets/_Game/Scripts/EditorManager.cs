using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables;

public class EditorManager : MonoBehaviour
{
    
    // Engine

    [SerializeField, Range(0, 10f)] private float _throttlePower;
    [SerializeField, Range(0, 10f)] private float _rotationPower;
    
    [SerializeField] private FloatVariable _throttlePowerObject;
    [SerializeField] private FloatVariable _rotationPowerObject;
    
    // Hull


    [SerializeField] private int _health;
    
    [SerializeField] private IntVariable _healthObject;

    public void AssignValues()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA yo");
        _throttlePowerObject.SetValue(_throttlePower);
        _rotationPowerObject.SetValue(_rotationPower);
        _healthObject.SetValue(_health);
    }
    



}
