namespace ThisGame
{
    public interface IGameManager
    {
        IPlayer ActivePlayer { get; }
        
        int Score { get; }

        void LoadNextLevel();
        void LoadPreviousLevel();
        void LoadMainMenuLevel();
    }
}