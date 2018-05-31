using UnityEngine;

public class Dog_2 : MonoBehaviour, ISpeak, IWalk, ISwim, IID
{
    public void Speak()
    {
        Debug.Log("Arf!");
    }

    public void Walk()
    {
        Debug.Log(gameObject.name + " is walking...");
    }

    public void Swim()
    {
        Debug.Log("Dog is dog-paddling...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
