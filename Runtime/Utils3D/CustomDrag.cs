using UnityEngine;

namespace Common.Physics3D
{
    [DisallowMultipleComponent]
    public class CustomDrag : MonoBehaviour
    {
        public float Drag;
        public float AngularDrag;
        public float SlipCompensationForce;

        [Header("References")]
        [SerializeField] private Rigidbody _rigidbody;

        private Rigidbody _rb;
        private float _initialDrag;
        private float _initialAngularDrag;

        // CORE

        private void Awake()
        {
            _initialDrag = _rb.drag;
            _initialAngularDrag = _rb.angularDrag;
        }

        // PUBLIC

        public void SetCustomDrag()
        {
            _initialDrag = _rb.drag;
            _rb.drag = Drag;
        }

        public void SetCustomAngularDrag()
        {
            _initialAngularDrag = _rb.angularDrag;
            _rb.angularDrag = AngularDrag;
        }

        public void ResetToDefaultDrag()
        {
            _rb.drag = _initialDrag;
        }

        public void ResetToDefaultAngularDrag()
        {
            _rb.angularDrag = _initialAngularDrag;
        }
    }
}
