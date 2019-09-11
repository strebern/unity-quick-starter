using System.Collections;
using UnityEngine;

namespace QuickStarter.Utils2D.Shooting
{
    [DisallowMultipleComponent]
    public class ShootingSystem : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private ShootingSystemSettings _settings;

        [Header("Spawn")]
        [SerializeField] private Transform _bulletSpawn;

        private Coroutine _shootingRoutine;
        private AudioSource shotSound;

        // PUBLIC

        public void StartShootingRoutine(Transform target)
        {
            StopShootingRoutine();
            _shootingRoutine = StartCoroutine(ShootingRoutine(target));
            shotSound = GetComponent<AudioSource>();
        }

        public void StopShootingRoutine()
        {
            if (_shootingRoutine != null)
            {
                StopCoroutine(_shootingRoutine);
                _shootingRoutine = null;
            }
        }

        // PRIVATE

        private IEnumerator ShootingRoutine(Transform target)
        {
            while (Application.isPlaying)
            {
                Shoot(target);
                shotSound.Play();
                yield return new WaitForSeconds(_settings.Firerate);
            }
        }

        private void Shoot(Transform target)
        {
            var bullet = Instantiate(_settings.BulletPrefab, _bulletSpawn.position, _bulletSpawn.rotation);
            var bulletRB = bullet.GetComponent<Rigidbody2D>();
            var bulletSettings = bullet.GetComponent<Bullet>().Settings;

            bulletRB.velocity = bullet.transform.up * bulletSettings.InitialForce;

            Destroy(bullet, bulletSettings.LifeSpan);
        }
    }
}
