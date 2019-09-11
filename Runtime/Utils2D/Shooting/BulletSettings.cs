using UnityEngine;

namespace QuickStarter.Utils2D.Shooting
{
    [CreateAssetMenu(menuName = "Shooting/BulletSettings", fileName = "BulletSettings")]
    public class BulletSettings : ScriptableObject
    {
        public float LifeSpan;
        public float InitialForce;
    }
}
