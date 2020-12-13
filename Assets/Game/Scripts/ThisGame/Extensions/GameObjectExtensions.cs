using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

namespace ThisGame
{
    [UsedImplicitly]
    public static class GameObjectExtensions
    {
        #region runtime

        // remove the comment when a runtime extension method added

        #endregion
        
        #region editor

#if UNITY_EDITOR
        /// <summary>
        /// Check if object is selected in Unity Editor.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns>True if object is selected in the Editor.</returns>
        public static bool SelectedInEditor(this GameObject gameObject)
        {
            var selected = Selection.activeGameObject;
            return selected && selected.Equals(gameObject);
        }
#endif

        #endregion
    }
}