using UnityEngine;

namespace QuickStarter.CameraUtils
{
    [DisallowMultipleComponent]
    public class LookAtCamera : MonoBehaviour
    {
        [Header("Camera")]
        [SerializeField] private Camera _camera;

        private void Awake()
        {
            if (!_camera)
            {
                _camera = Camera.main;
            }
        }

        private void Update()
        {
            if (_camera != null)
            {
                transform.LookAt(_camera.transform);
            }
        }
    }
}
