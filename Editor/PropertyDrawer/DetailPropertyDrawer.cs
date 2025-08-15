#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace UI
{
    [CustomPropertyDrawer(typeof(Detail))]
    public class DetailPropertyDrawer : PropertyDrawer
    {
        #region Attributes
        private Rect rect = new Rect();
        #endregion
        #region Methods
        public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
        {
            // Begin Property
            EditorGUI.BeginProperty(rect, label, serializedProperty);

            // Rect
            this.rect.x = rect.x;
            this.rect.y = rect.y;
            this.rect.width = EditorGUIUtility.labelWidth;
            this.rect.height = EditorGUIUtility.singleLineHeight;
            
            // Title
            property = serializedObject.FindProperty(Detail.propertyTitle);
            this.rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(this.rect, property, Detail.guiTitle);
            // Short
            property = serializedObject.FindProperty(Detail.propertyShortTitle);
            this.rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(this.rect, property, Detail.guiShortTitle);
            // Description
            property = serializedObject.FindProperty(Detail.propertyDescription);
            this.rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(this.rect, property, Detail.guiDescription);
            // Texture 2D
            property = serializedObject.FindProperty(Detail.propertyTexture2D);
            this.rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(this.rect, property, Detail.guiTexture2D);

            // End Property
            EditorGUI.EndProperty();
        }
        public override float GetPropertyHeight(SerializedProperty serializedProperty, GUIContent label)
        {
            float propertyHeight = 0f;
            // Title
            propertyHeight += EditorGUI.GetPropertyHeight(
                serializedObject.FindProperty(Detail.propertyTitle)
            ) + EditorGUIUtility.standardVerticalSpacing;
            // Short
            propertyHeight += EditorGUI.GetPropertyHeight(
                serializedObject.FindProperty(Detail.propertyShortTitle)
            ) + EditorGUIUtility.standardVerticalSpacing;
            // Description
            propertyHeight += EditorGUI.GetPropertyHeight(
                serializedObject.FindProperty(Detail.propertyDescription)
            ) + EditorGUIUtility.standardVerticalSpacing;
            // Texture 2D
            propertyHeight += EditorGUI.GetPropertyHeight(
                serializedObject.FindProperty(Detail.propertyTexture2D)
            ) + EditorGUIUtility.standardVerticalSpacing;
            
            return propertyHeight;
        }
        #endregion
    }
}

#endif