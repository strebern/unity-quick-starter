using UnityEngine;

[CreateAssetMenu(menuName = "Primitives/Bool")]
public class BoolVariable : ScriptableObject
{
    public bool Value;

    public static implicit operator bool(BoolVariable b)
    {
        return b.Value;
    }
}
