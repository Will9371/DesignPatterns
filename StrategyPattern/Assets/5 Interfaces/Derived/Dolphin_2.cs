using UnityEngine;

public class Dolphin_2 : MonoBehaviour, ISpeak, ISwim, IID
{
    public void Speak()
    {
        Debug.Log("EekEekEek!");
    }

    public void Swim()
    {
        Debug.Log("Dolphin is swimming...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
