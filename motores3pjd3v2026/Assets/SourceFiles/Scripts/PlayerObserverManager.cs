using System;

public static class PlayerObserverManager
{
    public static event Action<int> OnCoinsChanged;

    public static void NotifyCoinsChanged(int coins)
    {
        OnCoinsChanged?.Invoke(coins);
    }
}