using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory_UI inventory;

    public List<TMP_Text> slotTexts;

    void Start()
    {
        inventory = new Inventory_UI(slotTexts.Count);

        for (int i = 0; i < slotTexts.Count; i++)
        {
            inventory.slots[i].countText = slotTexts[i];
        }
    }
    private void Awake()
    {
        inventory = new Inventory_UI(6);

    }
}
