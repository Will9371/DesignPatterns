using UnityEngine;

public class Cat_2 : MonoBehaviour, ISpeak, IWalk, IID
{
    public void Speak()
    {
        Debug.Log("Meow!");
    }

    public void Walk()
    {
        Debug.Log(gameObject.name + " is walking...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
