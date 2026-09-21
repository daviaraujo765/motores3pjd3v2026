using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinsChanged += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinsChanged -= UpdateUI;
    }

    void UpdateUI(Player player, int coins)
    {
        if (player != this.player)
            return;

        coinsText.text = "Moedas: " + coins;
    }
}