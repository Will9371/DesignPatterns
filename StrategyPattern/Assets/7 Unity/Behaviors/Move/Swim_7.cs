using UnityEngine;

public class Swim_7 : MonoBehaviour, IMove_7
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is swimming");
    }
}
