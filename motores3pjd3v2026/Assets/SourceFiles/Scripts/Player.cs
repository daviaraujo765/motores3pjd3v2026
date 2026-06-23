using UnityEngine;

public class Player : MonoBehaviour
{
    int coins = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += CollectCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= CollectCoin;
    }


    void CollectCoin()
    {
        coins++;

        PlayerObserverManager.NotifyCoinsChanged(coins);
    }
}