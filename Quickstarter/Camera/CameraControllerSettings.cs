using UnityEngine;

namespace QuickStarter.CameraUtils
{
    [CreateAssetMenu(menuName = "Camera/CameraControllerSettings")]
    public class CameraControllerSettings : ScriptableObject
    {
        [Header("Sensitivity")]
        public float XSensitivity;
        public float YSensitivity;

        [Header("Clamping Values")]
        public float XMinimumValue = -360f;
        public float XMaximumValue = 360f;
        [Space(10)]
        public float YMinimumValue = -60f;
        public float YMaximumValue = 60f;
    }
}
