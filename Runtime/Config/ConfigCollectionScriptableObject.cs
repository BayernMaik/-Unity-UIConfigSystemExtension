using UnityEngine;

namespace UI
{
    /// <summary>
    /// ScriptableObject holding a List of Configs
    /// </summary>
    public abstract class ConfigCollectionScriptableObject<T, U> : ScriptableObject
    {
        #region Attributes
        [SerializeField] private ConfigList<T, U> collection;
        #endregion
        #region Properties
        public ConfigList<T, U> Collection
        {
            get { return this.collection; }
            set { this.collection = value; }
        }
        #endregion
        #region Methods
        public ConfigList<T, U> GetCollection()
        {
            return this.collection;
        }
        public void SetData(ConfigList<T, U> collection)
        {
            this.collection = collection;
        }

        // Get Config (Class)
        /// <summary>
        /// Get Config corresponding with Reference of given Type
        /// </summary>
        /// <typeparam name="T">Type of Reference</typeparam>
        /// <param name="t">Reference to get Config for</param>
        /// <returns>Config if configured, null otherwise</returns>
        public Config<T, U> GetConfig(T t)
        {
            if (this.collection != null)
            {
                return this.collection.GetConfig(t);
            }
            return null;
        }
        #endregion
    }
}