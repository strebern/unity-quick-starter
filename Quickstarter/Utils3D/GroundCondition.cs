using UnityEngine;
using UnityEngine.Events;

namespace QuickStarter.Physics3D
{
    [DisallowMultipleComponent]
    public class GroundCondition : MonoBehaviour
    {
        [Header("State")]
        public bool IsGrounded = false;

        [Header("Parameters")]
        [SerializeField] private string _groundLayerName;
        [SerializeField] private float _distanceForGrounded;
        [SerializeField] private Vector3 _offset;

        [Header("Events")]
        public UnityEvent OnHitGround;
        public UnityEvent OnLeftGround;

        // MONO

        private void FixedUpdate()
        {
            CheckGrounded();
        }

        // PRIVATE

        private void CheckGrounded()
        {
            if (Physics.Raycast
                (
                transform.position + _offset,
                transform.TransformDirection(Vector3.down),
                _distanceForGrounded,
                1 << LayerMask.NameToLayer(_groundLayerName)
                ))
            {
                if (!IsGrounded)
                {
                    IsGrounded = true;
                    OnHitGround.Invoke();
                }
            }
            else
            {
                if (IsGrounded)
                {
                    IsGrounded = false;
                    OnLeftGround.Invoke();
                }
            }
        }

        // GIZMOS

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Vector3 direction = transform.TransformDirection(Vector3.down) * _distanceForGrounded;
            Gizmos.DrawRay(transform.position + _offset, direction);
        }
    }
}
