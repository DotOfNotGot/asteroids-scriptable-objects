using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Variables;


public class ShipConstructorWindow : EditorWindow
{

    public EditorManager _editorManager;    
    
    public VisualTreeAsset m_UXML;
    
    private VisualElement _root;
    
    [SerializeField] private FloatVariable _throttlePowerObject;
    [SerializeField] private FloatVariable _rotationPowerObject;
    [SerializeField] private IntVariable _healthObject;

    private float throttlePowerSlider;
    private float rotationPowerSlider;
    private int healthField;
    
    [MenuItem("Window/Ship Constructor")]
    public static void ShowWindow()
    {
        GetWindow<ShipConstructorWindow>("Ship Constructor");
    }
    
    private void CreateGUI()
    {

        _root = new VisualElement();

        _editorManager = new EditorManager();
        
        m_UXML.CloneTree(_root);
        
        BindTree();
        
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAA");

        SerializedObject throttleObject = new SerializedObject(_throttlePowerObject); 
        SerializedObject rotateObject = new SerializedObject(_rotationPowerObject);
        SerializedObject healthObject = new SerializedObject(_healthObject);

        // throttlePowerSlider = new Slider(0, 10f, SliderDirection.Horizontal);
        // rotationPowerSlider = new Slider(0, 10f, SliderDirection.Horizontal);
        // healthField = new IntegerField(50);
        
        
        
        rootVisualElement.Bind(throttleObject);
        rootVisualElement.Bind(rotateObject);
        rootVisualElement.Bind(healthObject);
        
        
        rootVisualElement.Add(_root);
    }


    private void AssignValues()
    {
        _throttlePowerObject.SetValue(throttlePowerSlider);
        _rotationPowerObject.SetValue(rotationPowerSlider);
        _healthObject.SetValue(healthField);
    }
    
    void BindTree()
    {
        var generateButton = _root.Q<Button>("Generate");
       generateButton.clicked += AssignValues;
        
        Debug.Log(generateButton.name);
    }

    private void OnGUI()
    {
        
        Debug.Log("PLEASE");
        
    }
}
