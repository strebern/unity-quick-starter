using UnityEngine;

[CreateAssetMenu(menuName = "Primitives/Float")]
public class FloatVariable : ScriptableObject
{
    public float Value;

    public static implicit operator float(FloatVariable f)
    {
        return f.Value;
    }
}
