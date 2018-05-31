using UnityEngine;

public interface ISpeak_1 { void Speak(); }

public class Bark : ISpeak_1
{
    public void Speak()
    {
        Debug.Log("Arf!");
    }
}

public class Meow : ISpeak_1
{
    public void Speak()
    {
        Debug.Log("Meow!");
    }
}

public class Whistle : ISpeak_1
{
    public void Speak()
    {
        Debug.Log("EekEekEek!");
    }
}

public class Silence : ISpeak_1
{
    public void Speak() { }
}

public class Bleep : ISpeak_1
{
    public void Speak()
    {
        Debug.Log("Bleep Blorp!");
    }
}


