using UnityEngine;
using UnityEngine.UI;

public class InventÁrio_UI : MonoBehaviour
{
    public GameObject inventoryPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();

        }

    }
    public void ToggleInventory()
    {
        if (!inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(true);
        }
        else 
        {
            inventoryPanel.SetActive(false);
        }
          
    }
}
