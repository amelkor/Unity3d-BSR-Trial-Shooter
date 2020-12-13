namespace ThisGame
{
    public interface IPlayer
    {
        IHealthManager Health { get; }
        ICharacterMovement Movement { get; }
        ICharacterFirstPersonLook FirstPersonLook { get; }
    }
}