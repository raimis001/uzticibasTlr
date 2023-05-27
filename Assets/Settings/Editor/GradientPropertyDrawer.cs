using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Gradient))]
public class GradientPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // yes, this is stupid, and only for the visual scripting system:
        EditorGUI.PropertyField(position, property, label);
    }
}