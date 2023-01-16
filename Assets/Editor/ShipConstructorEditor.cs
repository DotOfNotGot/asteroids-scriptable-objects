using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(EditorManager))]
public class ShipConstructorEditor : Editor
{
    
    public VisualTreeAsset m_UXML;

    private VisualElement _root = new VisualElement();

    private EditorManager _editorManager;
    
    
    public override VisualElement CreateInspectorGUI()
    {

        //_editorManager = (EditorManager)target;
        
        _root = new VisualElement();

        m_UXML.CloneTree(_root);

        
        //BindTree();
        
        var generateButton = _root.Q<Button>("Generate");

        if (generateButton == null)
        {
            Debug.Log("null button");
        }
        
        generateButton.clicked += _editorManager.AssignValues;
                
        Debug.Log(generateButton.name);
        
        
        return _root;
    }
    

    void BindTree()
    {
        var generateButton = _root.Q<Button>("Generate");
        generateButton.clicked += _editorManager.AssignValues;
        
        Debug.Log(generateButton.name);
    }
}
