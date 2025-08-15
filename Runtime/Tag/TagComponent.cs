using UnityEngine;

namespace UI
{
    public class TagComponent : MonoBehaviour
    {
        #region Attributes
        [SerializeField] private Tag uiTag;
        #endregion
        #region Properties
        public Tag UiTag
        {
            get { return this.uiTag; }
            set { this.uiTag = value; }
        }
        #endregion
        #region Methods
        public Tag GetTag()
        {
            return this.uiTag;
        }
        public void SetTag(Tag tag)
        {
            this.uiTag = tag;
        }
        #endregion
    }
}