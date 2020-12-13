using UnityEngine;

namespace ThisGame
{
    /// <summary>
    /// A bridge between character and <see cref="Animator"/> component.
    /// </summary>
    public interface ICharacterAnimator
    {
        /// <summary>
        /// Velocity vector to control movement animation.
        /// </summary>
        Vector3 Velocity { get; set; }

        /// <summary>
        /// Triggers weapon fire animation.
        /// </summary>
        void Fire();

        /// <summary>
        /// Triggers weapon melee animation.
        /// </summary>
        void Melee();
        
        /// <summary>
        /// Triggers weapon reload animation.
        /// </summary>
        /// <param name="empty">If true then should do full reload with cock animation.</param>
        void Reload(bool empty);
    }
}