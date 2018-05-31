using UnityEngine;

public class Tuna_2 : MonoBehaviour, ISwim, IID
{
    public void Swim()
    {
        Debug.Log("Tuna is swimming...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
