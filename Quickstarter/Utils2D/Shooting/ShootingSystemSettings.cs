﻿using UnityEngine;

namespace QuickStarter.Utils2D.Shooting
{
    [CreateAssetMenu(menuName = "Shooting/ShootingSystemSettings", fileName = "ShootingSystemSettings")]
    public class ShootingSystemSettings : ScriptableObject
    {
        public float Firerate;
        public GameObject BulletPrefab;
    }
}
