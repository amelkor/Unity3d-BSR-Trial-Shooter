using UnityEngine;

namespace ThisGame.Components.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Look settings")]
        [SerializeField] private float lookSensivityX;
        [SerializeField] private float lookSensivityY;

        [Header("Movement settings")]
        [SerializeField] private float speed;
        [SerializeField] private float jumpForce;

        private CharacterController _character;

        private void Awake()
        {
            _character = GetComponent<CharacterController>();
        }

        #region editor

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            gameObject.DrawCharacterControllerGizmos();
        }
#endif

        #endregion
    }
}