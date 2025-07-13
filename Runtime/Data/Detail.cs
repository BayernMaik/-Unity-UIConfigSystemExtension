using System;
using UnityEngine;

namespace UI
{
    [Serializable]
    public struct Detail : IDetail
    {
        #region Attributes
        [SerializeField] private string title;
        [SerializeField] private string shortTitle;
        [SerializeField] private string description;
        [SerializeField] private Texture2D texture2D;
        #endregion
        #region Properties
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string ShortTitle
        {
            get { return this.shortTitle; }
            set { this.shortTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public Texture2D Texture2D
        {
            get { return this.texture2D; }
            set { this.texture2D = value; }
        }
        #endregion
        #region Methods
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        #endregion
        #region Unity Editor
        public const string propertyTitle = "title";
        public const string propertyShortTitle = "shortTitle";
        public const string propertyDescription = "description";
        public const string propertyTexture2D = "texture2D";
        public static readonly GUIContent guiTitle = new GUIContent(
            "Title",
            "Detail Data Title"
        );
        public static readonly GUIContent guiShortTitle = new GUIContent(
            "Short",
            "Detail Data Short Title"
        );
        public static readonly GUIContent guiDescription = new GUIContent(
            "Description",
            "Detail Data Description"
        );
        public static readonly GUIContent guiTexture2D = new GUIContent(
            "Texture(2D)",
            "Detail Data Texture2D"
        );
        #endregion
    }
}