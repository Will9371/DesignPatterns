using UnityEngine;

public abstract class Animal_1 : MonoBehaviour
{
    public virtual int Speak() { return 0; }
    public virtual int Walk() { return 0; }
    public virtual int Swim() { return 0; }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }


}
