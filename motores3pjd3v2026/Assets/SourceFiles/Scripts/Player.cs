using UnityEngine;

public class Player : MonoBehaviour
{
    int coins = 0;

    public void CollectCoin()
    {
        coins++;

        PlayerObserverManager.NotifyCoinsChanged(coins);
    }
}