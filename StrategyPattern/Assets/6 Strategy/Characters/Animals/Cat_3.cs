public class Cat_3 : Animal_3
{
    void Start()
    {
        speakBehavior = new Meow();
        moveBehavior = new Walk();
    }
}
