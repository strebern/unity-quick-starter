using UnityEngine;

namespace QuickStarter.Physics3D
{
    [DisallowMultipleComponent]
    public class Hovering : MonoBehaviour
    {
        public bool Enabled = true;

        [Header("Settings")]
        [SerializeField] private string _groundLayerName;
        [SerializeField] private FloatVariable _hoveringHeight;

        [Header("References")]
        [SerializeField] private Rigidbody _rb;

        // CORE

        private void FixedUpdate()
        {
            Hover();
        }

        // PUBLIC

        public void Enable()
        {
            _rb.useGravity = true;
            Enabled = true;
        }

        public void Disable()
        {
            _rb.useGravity = true;
            Enabled = false;
        }

        // PRIVATE

        private void Hover()
        {
            if (Enabled)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, Vector3.down, out hit, _hoveringHeight.Value, 1 << LayerMask.NameToLayer(_groundLayerName)))
                {
                    _rb.useGravity = false;
                    _rb.velocity = new Vector3(_rb.velocity.x, 0, _rb.velocity.z);
                    transform.position = new Vector3(transform.position.x, hit.point.y + _hoveringHeight.Value, transform.position.z);
                }
                else
                {
                    _rb.useGravity = true;
                }
            }
        }
    }
}
