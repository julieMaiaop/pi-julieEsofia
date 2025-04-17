using UnityEngine;

public class ItemColector : MonoBehaviour
{
    public CollectableType type;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player)
        {
            player.inventory.Add(type);
            Destroy(this.gameObject);
        }
    }
}
public enum CollectableType
{
    NONE, CARROT_SEED
}