using UnityEngine;

public interface IMove_7 { void Move(string characterName); }
public interface ISpeak_7 { void Speak(); }

public class Character_7 : MonoBehaviour
{
    public IMove_7[] moveBehaviors;
    public ISpeak_7[] speakBehaviors;

    int moveID = 0;
    int speakID = 0;

    private void Start()
    {
        moveBehaviors = GetComponents<IMove_7>();
        speakBehaviors = GetComponents<ISpeak_7>();
    }

    public void PerformMove()
    {
        moveBehaviors[moveID].Move(gameObject.name);
    }

    public void PerformSpeak()
    {
        speakBehaviors[speakID].Speak();
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }

    public void ChangeMoveState()
    {
        if (moveID >= moveBehaviors.Length - 1)
            moveID = 0;
        else
            moveID++;
    }

    public void ChangeSpeakState()
    {
        if (speakID >= speakBehaviors.Length - 1)
            speakID = 0;
        else
            speakID++;
    }
}
