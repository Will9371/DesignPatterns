using UnityEngine;

public class Dog_1 : Animal_1
{
    public override int Speak()
    {
        Debug.Log("Arf!");
        return 1;
    }

    public override int Walk()
    {
        Debug.Log("Dog is walking...");
        return 1;
    }

    public override int Swim()
    {
        Debug.Log("Dog is dog-paddling...");
        return 1;
    }
}
