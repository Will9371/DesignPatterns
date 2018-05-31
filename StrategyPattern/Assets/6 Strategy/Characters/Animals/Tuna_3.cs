using UnityEngine;

public class Tuna_3 : Animal_3
{
    void Start()
    {
        speakBehavior = new Silence();
        moveBehavior = new Swim();
    }

    public override void ChangeMoveState()
    {
        if (moveBehavior.GetType() == typeof(Swim))
            moveBehavior = new Fly();
        else
            moveBehavior = new Swim();
    }
}
