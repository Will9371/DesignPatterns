using UnityEngine;

public class Robot_1 : Animal_1
{
    public override int Speak()
    {
        Debug.Log("Bleep blorp!");
        return 1;
    }

    public override int Walk()
    {
        Debug.Log("Robot is walking...");
        return 1;
    }
}
