using UnityEngine;

namespace QuickStarter.Utils2D
{
    [DisallowMultipleComponent]
    public class LookAtTarget : MonoBehaviour
    {
        [Header("Target")]
        public Transform Target;

        [Header("Pivot")]
        public Transform Pivot;

        [Header("Settings")]
        public float Offset;

        // MONO

        private void Update()
        {
            LookTowardsTarget();
        }

        // PRIVATE

        private void LookTowardsTarget()
        {
            if (Target)
            {
                if (Pivot)
                {
                    var targetDirection = Target.position - transform.position;
                    var angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

                    transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + Offset));
                }
                else
                {
                    transform.LookAt(Target);
                }
            }
        }
    }
}
