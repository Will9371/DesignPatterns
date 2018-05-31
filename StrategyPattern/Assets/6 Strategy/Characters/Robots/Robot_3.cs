public class Robot_3 : RobotCharacter
{
    private void Start()
    {
        speakBehavior = new Bleep();
        moveBehavior = new Walk();
    }

    public override void ChangeMoveState()
    {
        if (moveBehavior.GetType() == typeof(Walk))
            moveBehavior = new Fly();
        else
            moveBehavior = new Walk();
    }
}