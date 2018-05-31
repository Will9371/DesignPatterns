using UnityEngine;

public class Giraffe_2 : MonoBehaviour, IWalk, IID
{
    public void Walk()
    {
        Debug.Log(gameObject.name + " is walking...");
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
