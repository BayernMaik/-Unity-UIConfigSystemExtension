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
    }
}