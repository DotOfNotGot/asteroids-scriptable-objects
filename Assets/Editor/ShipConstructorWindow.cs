using System;
using System.Collections;
using System.Collections.Generic;
using PlasticGui.Configuration.CloudEdition.Welcome;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Variables;


public class ShipConstructorWindow : EditorWindow
{

    public VisualTreeAsset m_UXML;
    
    private VisualElement _root;


    private Configuration _config;
    
    private List<VisualElement> _changeables = null;

    [MenuItem("Window/Ship Constructor")]
    public static void ShowWindow()
    {
        GetWindow<ShipConstructorWindow>("Ship Constructor");
    }


    private void OnEnable()
    {
        _config = AssetDatabase.LoadAssetAtPath<Configuration>("Assets/Data Assets/new Configuration.asset");
        Debug.Log(_config);
    }

    private void CreateGUI()
    {

        _root = new VisualElement();

        m_UXML.CloneTree(_root);
        
        rootVisualElement.Add(_root);
        
        if (_changeables == null)
        {
            _changeables = rootVisualElement.Query(className: "BindableElement").ToList();
        }

        foreach (var changeable in _changeables)
        {
            Debug.Log(changeable);
        }

        BindAssets();
        
    }



    private void BindAssets()
    {
        foreach (var changeable in _changeables)
        {
            if (changeable == null) continue;

            var obj = _config.FindScriptableObjects(changeable.name);
            
            if(obj == null) continue;

            SerializedObject newSerial = new SerializedObject(obj);
            
            changeable.Bind(newSerial);

        }
    }
    
}
