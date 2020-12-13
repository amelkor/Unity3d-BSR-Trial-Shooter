using UnityEngine;

namespace ThisGame
{
    public interface ICharacterMovement : IControlInput
    {
        bool Grounded { get; }
        bool Sprinting { get; }
        float MovementSpeed { get; }
        float MovementSpeedMin { get; }
        float MovementSpeedMan { get; }

        /// <summary>
        /// Move character by input <paramref name="direction"/>.
        /// </summary>
        /// <param name="direction">Input direction</param>
        void Move(Vector3 direction);

        /// <summary>
        /// Teleports character to the desired location.
        /// </summary>
        /// <param name="position">Target position</param>
        /// <param name="rotation">Target rotation</param>
        void Warp(Vector3 position, Quaternion rotation);
    }
}