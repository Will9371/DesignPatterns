using UnityEngine;

[CreateAssetMenu]
public class SpeakStyles : ScriptableObject
{
    [SerializeField] string speakStatement;

    public void Speak()
    {
        Debug.Log(speakStatement);
    }
}
