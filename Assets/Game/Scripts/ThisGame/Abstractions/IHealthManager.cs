using System;

namespace ThisGame
{
    public interface IHealthManager
    {
        event Action Killed;
        event Action<int> HealthChanged;
        
        int CurrentHealth { get; }
        int MaxHealth { get; }

        void Kill();
        void RestoreHealth(int amount);
    }
}