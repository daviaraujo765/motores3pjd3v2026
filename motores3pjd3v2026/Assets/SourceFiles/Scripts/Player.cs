using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int playerNumber;
    
    int coins = 0;
    
    public int PlayerNumber => playerNumber;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += CollectCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= CollectCoin;
    }

    void CollectCoin(Player player)
    {
        if (player != this)
            return;

        coins++;

        PlayerObserverManager.NotifyCoinsChanged(this, coins);
    }
}