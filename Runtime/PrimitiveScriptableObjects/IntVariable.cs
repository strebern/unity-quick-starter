using UnityEngine;

[CreateAssetMenu(menuName = "Primitives/Int")]
public class IntVariable : ScriptableObject
{
    public int Value;

    public static implicit operator int(IntVariable i)
    {
        return i.Value;
    }
}

