using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event System.Action OnObjectCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnObjectCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
