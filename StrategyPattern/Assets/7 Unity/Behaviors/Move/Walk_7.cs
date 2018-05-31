using UnityEngine;

public class Walk_7 : MonoBehaviour, IMove_7
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is walking");
    }
}
