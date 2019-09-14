using UnityEngine;

namespace QuickStarter.TransformUtils
{
    [CreateAssetMenu(menuName = "TransformUtils/ScaleModifierSettings", fileName = "ScaleModifierSettings")]
    public class ScaleModifierSettings : ScriptableObject
    {
        public bool StartIncreaseOnAwake = true;
        public float SecondsBeforeFullSize;
        public Vector3 TargetSize;
        public Vector3 StartSize;
    }
}
