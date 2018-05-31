using UnityEngine;

public class DogPaddle_7 : MonoBehaviour, IMove_7
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is dog-paddling");
    }
}
