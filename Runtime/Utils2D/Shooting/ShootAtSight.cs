using System.Collections.Generic;
using UnityEngine;

namespace QuickStarter.Utils2D.Shooting
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class ShootAtSight : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private ShootingSystem _shootingSystem;

        [Header("Targets")]
        public List<string> TargetsTags;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            foreach (var tag in TargetsTags)
            {
                if (collision.gameObject.CompareTag(tag))
                {
                    _shootingSystem.StartShootingRoutine(collision.gameObject.transform);
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            foreach (var tag in TargetsTags)
            {
                if (collision.gameObject.CompareTag(tag))
                {
                    _shootingSystem.StopShootingRoutine();
                }
            }
        }
    }
}
