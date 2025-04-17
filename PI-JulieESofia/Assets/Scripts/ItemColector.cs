using UnityEngine;

public class ItemColector : MonoBehaviour
{


    public int itemCount = 0; // Contador de itens coletados

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            itemCount++; // Aumenta o contador
            Destroy(other.gameObject); // Remove o item da cena
            Debug.Log("Item coletado! Total: " + itemCount);
        }
    }
}
