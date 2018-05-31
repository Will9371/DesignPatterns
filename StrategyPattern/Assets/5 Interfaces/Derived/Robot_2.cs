using UnityEngine;

public class Robot_2 : MonoBehaviour, ISpeak, IWalk, IID
{
    public void Speak()
    {
        Debug.Log("Bleep blorp!");
    }

    public void Walk()
    {
        Debug.Log("Robot is walking...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
