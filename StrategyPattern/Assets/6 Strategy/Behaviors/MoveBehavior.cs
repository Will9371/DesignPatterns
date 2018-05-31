using UnityEngine;

public interface IMove { void Move(string characterName); }

public class Walk : MonoBehaviour, IMove
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is walking");
    }
}

public class Swim : MonoBehaviour, IMove
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is swimming");
    }
}

public class DogPaddle : MonoBehaviour, IMove
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is dog-paddling");
    }
}

public class Fly : MonoBehaviour, IMove
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is flying");
    }
}

public class Dance : MonoBehaviour, IMove
{
    public void Move(string characterName)
    {
        Debug.Log(characterName + " is dancing");
    }
}
