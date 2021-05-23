using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Pixelate))]
public class PixelateEditor : Editor
{
    public override void OnInspectorGUI()   
    {
        Pixelate pc = (Pixelate)target;

        // When the inspector is drawn (or any values are changed) re-initialize the render texture
        if (DrawDefaultInspector() || pc.CheckScreenResize()) pc.Init();
    }
}
