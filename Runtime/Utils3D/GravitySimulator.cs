using UnityEngine;

namespace Common.Physics3D
{
    [DisallowMultipleComponent]
    public class GravitySimulator : MonoBehaviour
    {
        [Header("Settings")]
        public FloatVariable GravityForce;
        public bool UseWorldCoordinates;
        public ForceMode ForceMode;

        [Header("References")]
        [SerializeField] private Rigidbody _rb;

        // MONO

        private void FixedUpdate()
        {
            ApplyGravity();
        }

        // PUBLIC

        public void ApplyGravity()
        {
            if (UseWorldCoordinates)
            {
                _rb.AddForce(Vector3.down * GravityForce.Value, ForceMode);
            }
            else
            {
                _rb.AddRelativeForce(Vector3.down * GravityForce.Value, ForceMode);
            }
        }
    }
}
