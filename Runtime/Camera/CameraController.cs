using UnityEngine;

namespace QuickStarter.CameraUtils
{
    [RequireComponent(typeof(Camera))]
    public class CameraController : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private CameraControllerSettings _settings;

        private float yRotation = 0f;

        // MONO

        private void LateUpdate()
        {
            UpdateCameraAngle();
        }

        // PRIVATE

        private void UpdateCameraAngle()
        {
            var xRotation = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _settings.XSensitivity;

            yRotation += Input.GetAxis("Mouse Y") * _settings.YSensitivity;
            yRotation = Mathf.Clamp(yRotation, _settings.XMinimumValue, _settings.XMaximumValue);

            transform.localEulerAngles = new Vector3(-yRotation, xRotation, 0);
        }
    }
}
