using System;
using UnityEngine;

public static class PlayerObserverManager
{
    public static event Action<Player> OnCoinCollected;
    public static event Action<Player, int> OnCoinsChanged;

    public static void NotifyCoinsChanged(Player player, int coins)
    {
        OnCoinsChanged?.Invoke(player, coins);
    }

    public static void NotifyCoinCollected(Player player)
    {
        OnCoinCollected?.Invoke(player);
    }
}