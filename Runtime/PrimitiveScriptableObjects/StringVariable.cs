using UnityEngine;

[CreateAssetMenu(menuName = "Primitives/String")]
public class StringVariable : ScriptableObject
{
    public string Value;

    public static implicit operator string(StringVariable s)
    {
        return s.Value;
    }
}
