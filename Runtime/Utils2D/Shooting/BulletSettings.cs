using UnityEngine;

namespace Common.Utils2D.Shooting
{
    [CreateAssetMenu(menuName = "Shooting/BulletSettings", fileName = "BulletSettings")]
    public class BulletSettings : ScriptableObject
    {
        public float LifeSpan;
        public float InitialForce;
    }
}
