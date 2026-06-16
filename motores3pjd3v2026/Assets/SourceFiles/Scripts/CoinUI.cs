using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinsText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinsChanged += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinsChanged -= UpdateUI;
    }

    void UpdateUI(int coins)
    {
        coinsText.text = "Moedas: " + coins;
    }
}