using System.Collections.Generic;
using UnityEngine;

public class Character_8 : MonoBehaviour
{
    [SerializeField] List<MoveStyles> moveStyles = new List<MoveStyles>();
    [SerializeField] List<SpeakStyles> speakStyles = new List<SpeakStyles>();
    int moveID, speakID;

    public void PerformSpeak()
    {
        if (speakStyles.Count > 0 && speakStyles[speakID] != null)
            speakStyles[speakID].Speak();
    }

    public void PerformMove()
    {
        if (moveStyles.Count > 0 && moveStyles[moveID] != null)
            moveStyles[moveID].Move(gameObject.name);
    }

    public void ChangeSpeakState()
    {
        speakID++;
        if (speakID >= speakStyles.Count)
            speakID = 0;
    }

    public void ChangeMoveState()
    {
        moveID++;
        if (moveID >= moveStyles.Count)
            moveID = 0;
    }

    public void LearnMovement(MoveStyles newMove)
    {
        if (!moveStyles.Contains(newMove))  
        {
            moveStyles.Add(newMove);
            Debug.Log(gameObject.name + " has learned to dance!");
        }
    }

    public void Identify()
    {
        Debug.Log("I am a " + gameObject.name);
    }
}
