using UnityEngine;

public class Character : MonoBehaviour
{
    public IMove moveBehavior;
    public ISpeak_1 speakBehavior;

    public void PerformMove()
    {
        moveBehavior.Move(gameObject.name);
    }

    public void PerformSpeak()
    {
        speakBehavior.Speak();
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }

    public virtual void ChangeMoveState() { }
}
