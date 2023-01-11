using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;


[CustomEditor(typeof(Engine))]
public class EngineEditor : Editor
{

    public VisualTreeAsset m_UXML;

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        m_UXML.CloneTree(root);


        var foldout = new Foldout() { viewDataKey = "EngineFullInspector", text = "Full Inspector" };
        
        InspectorElement.FillDefaultInspector(foldout, serializedObject, this);
        
        root.Add(foldout);
        
        return root;
    }
    
    
}
