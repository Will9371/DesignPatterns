public class Dolphin_3 : Animal_3
{
    void Start()
    {
        speakBehavior = new Whistle();
        moveBehavior = new Swim();
    }
}
