using UnityEngine;

namespace QuickStarter.GameObjectUtils
{
    [DisallowMultipleComponent]
    public class DontDestroyOnLoad : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}