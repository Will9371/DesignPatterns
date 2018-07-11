using UnityEngine;

[CreateAssetMenu]
public class MoveStyles : ScriptableObject
{
    [SerializeField] string moveStatement;

    public void Move(string name)
    {
        Debug.Log(name + " is " + moveStatement);
    }
}
