using UnityEngine;

public class Giraffe_3 : Animal_3
{
    void Start()
    {
        speakBehavior = new Silence();
        moveBehavior = new Dance();
    }
}
