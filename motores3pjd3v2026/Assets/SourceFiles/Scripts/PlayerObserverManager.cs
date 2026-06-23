using System;

public static class PlayerObserverManager
{
    public static event Action<int> OnCoinsChanged;

    public static event Action OnCoinCollected;


    public static void NotifyCoinsChanged(int coins)
    {
        OnCoinsChanged?.Invoke(coins);
    }


    public static void NotifyCoinCollected()
    {
        OnCoinCollected?.Invoke();
    }
}