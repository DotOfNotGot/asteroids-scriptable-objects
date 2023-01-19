using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Tools/Configuration", fileName = "new Configuration")]
public class Configuration : ScriptableObject
{

    public ScriptableObject[] Configurables;

    public ScriptableObject FindScriptableObjects(string name)
    {

        foreach (var so in Configurables)
        {

            if (so.name.Equals(name))
            {
                return so;
            }

        }
        
        return null;
    }
    

}
