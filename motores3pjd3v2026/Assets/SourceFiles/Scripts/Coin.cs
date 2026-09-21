using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponentInParent<Player>();

            if (player != null)
            {
                PlayerObserverManager.NotifyCoinCollected(player);
                Destroy(gameObject);
            }
        }
    }
}