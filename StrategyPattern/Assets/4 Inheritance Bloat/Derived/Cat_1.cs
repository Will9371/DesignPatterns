using UnityEngine;

public class Cat_1 : Animal_1
{
    public override int Speak()
    {
        Debug.Log("Meow!");
        return 1;
    }

    public override int Walk()
    {
        Debug.Log("Cat is walking...");
        return 1;
    }
}
