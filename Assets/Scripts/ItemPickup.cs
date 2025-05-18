using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other.gameObject);
        }
    }

    void Pickup(GameObject player)
    {
        // Placeholder for inventory logic
        Debug.Log($"Picked up {itemName}");
        Destroy(gameObject);
    }
}
