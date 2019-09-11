using UnityEngine;

namespace QuickStarter.GameObjectUtils
{
    public class ObjectDestroyer : MonoBehaviour
    {
        public void DestroySelf(float afterXSeconds = 0f)
        {
            Destroy(gameObject, afterXSeconds);
        }
    }
}
