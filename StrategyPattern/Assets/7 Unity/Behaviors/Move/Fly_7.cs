using UnityEngine;

public class Fly_7 : MonoBehaviour, IMove_7
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is flying");
    }
}
