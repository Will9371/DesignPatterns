public class Dog_3 : Animal_3
{
    void Start()
    {
        speakBehavior = new Bark();
        moveBehavior = new Walk();
    }

    public override void ChangeMoveState()
    {
        if (moveBehavior.GetType() == typeof(Walk))
            moveBehavior = new DogPaddle();
        else
            moveBehavior = new Walk();
    }
}
