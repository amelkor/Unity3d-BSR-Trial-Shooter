using UnityEngine;

namespace ThisGame
{
    public interface ICharacterFirstPersonLook : IControlInput
    {
        /// <summary>
        /// Update look based on <paramref name="axis"/> input.
        /// </summary>
        /// <param name="axis">Look input axis</param>
        void UpdateLook(Vector2 axis);

        /// <summary>
        /// Force to look at the specified direction for some time.
        /// </summary>
        /// <param name="direction">Look direction</param>
        /// <param name="time">Look duration in seconds</param>
        void ForceLookAt(Vector3 direction, float time);
    }
}