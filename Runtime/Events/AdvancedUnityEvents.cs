using UnityEngine;
using UnityEngine.Events;

namespace QuickStarter.Events
{
    // ADVANCED PRIMITIVE EVENTS

    [System.Serializable]
    public class DoubleIntEvent : UnityEvent<int, int> { }

    [System.Serializable]
    public class DoubleFloatEvent : UnityEvent<float, float> { }

    [System.Serializable]
    public class DoubleStringEvent : UnityEvent<string, string> { }

    [System.Serializable]
    public class DoubleBoolEvent : UnityEvent<bool, bool> { }

    // UNITY SPECIFICS

    [System.Serializable]
    public class ColorEvent : UnityEvent<Color> { }

    [System.Serializable]
    public class GameObjectEvent : UnityEvent<GameObject> { }
}
