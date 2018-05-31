using UnityEngine;

public class Dolphin_1 : Animal_1
{
    public override int Speak()
    {
        Debug.Log("EekEekEek!");
        return 1;
    }

    public override int Swim()
    {
        Debug.Log("Dolphin is swimming...");
        return 1;
    }
}
