using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(CreateWallScript))]
public class CreateWallEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        CreateWallScript cwScript = (CreateWallScript)target;
        if (GUILayout.Button("Create Wall")) {
            cwScript.CreateWall();
        }
    }
}
