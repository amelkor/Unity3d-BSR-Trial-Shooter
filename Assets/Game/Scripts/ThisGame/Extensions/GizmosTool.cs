#if UNITY_EDITOR
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

// ReSharper disable MemberCanBePrivate.Global

namespace ThisGame
{
    /// <summary>
    /// Provides various methods for gizmos drawing.
    /// </summary>
    [UsedImplicitly]
    public static class GizmosTool
    {
        public static void DrawCharacterControllerGizmos(this GameObject gameObject)
        {
#if UNITY_2019_1_OR_NEWER
            // ReSharper disable once InvertIf
            if (gameObject.TryGetComponent<CharacterController>(out var cc))
#else
            var cc = gameObject.GetComponent<CharacterController>();
            if (cc != null)
#endif
            {
                if (cc.height - cc.radius < cc.height / 2)
                    Gizmos.DrawWireSphere(gameObject.transform.position, cc.radius);
                else
                    DrawCapsuleGizmos(gameObject.transform.position + Vector3.up * cc.center.y, cc.height, cc.radius, ColorTool.LightPurple);
            }
        }

        public static void DrawCapsuleGizmos(Vector3 pos, float height, float radius, Color color)
        {
            DrawCapsuleGizmos(pos, Quaternion.identity, height, radius, color);
        }

        public static void DrawCapsuleGizmos(Vector3 pos, Quaternion rot, float height, float radius, Color color)
        {
            var angleMatrix = Matrix4x4.TRS(pos, rot, Handles.matrix.lossyScale);
            using (new Handles.DrawingScope(color, angleMatrix))
            {
                Gizmos.color = color;
                var pointOffset = (height - radius * 2) / 2;

                Handles.DrawWireArc(Vector3.up * pointOffset, Vector3.left, Vector3.back, -180, radius);
                Handles.DrawLine(new Vector3(0, pointOffset, -radius), new Vector3(0, -pointOffset, -radius));
                Handles.DrawLine(new Vector3(0, pointOffset, radius), new Vector3(0, -pointOffset, radius));
                Handles.DrawWireArc(Vector3.down * pointOffset, Vector3.left, Vector3.back, 180, radius);

                Handles.DrawWireArc(Vector3.up * pointOffset, Vector3.back, Vector3.left, 180, radius);
                Handles.DrawLine(new Vector3(-radius, pointOffset, 0), new Vector3(-radius, -pointOffset, 0));
                Handles.DrawLine(new Vector3(radius, pointOffset, 0), new Vector3(radius, -pointOffset, 0));
                Handles.DrawWireArc(Vector3.down * pointOffset, Vector3.back, Vector3.left, -180, radius);

                Handles.DrawWireDisc(Vector3.up * pointOffset, Vector3.up, radius);
                Handles.DrawWireDisc(Vector3.down * pointOffset, Vector3.up, radius);
            }
        }
    }
}
#endif