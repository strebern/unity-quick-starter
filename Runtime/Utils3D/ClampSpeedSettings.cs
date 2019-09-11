using UnityEngine;

namespace Common.Physics3D
{
    [CreateAssetMenu(menuName = "Physics3D/ClampSpeedSettings", fileName = "ClampSpeedSettings")]
    public class ClampSpeedSettings : ScriptableObject
    {
        [Header("ClampSpeed")]
        public float BaseClampSpeed;

        [Header("Extra Settings")]
        public bool ClampYAxis;
    }
}
