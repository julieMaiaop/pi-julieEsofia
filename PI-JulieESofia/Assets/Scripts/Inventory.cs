using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;


[System.Serializable]
public class Inventory_UI
{
    [System.Serializable]
    public class Slot
    {
        public CollectableType type;
        public int count;
        public int maxAllowed;
        public TMP_Text countText;

        public Slot()
        {
            type = CollectableType.NONE;
            count = 0;
            maxAllowed = 10;
        }

        public bool CanAddItem()
        {
            return count < maxAllowed;
        }

        public void AddItem(CollectableType type)
        {
            this.type = type;
            count++;
            countText.text = count.ToString();
        }
    }

    public List<Slot> slots = new List<Slot>();

    public Inventory_UI(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            slots.Add(new Slot());
        }
    }

    public void Add(CollectableType typeToAdd)
    {
        foreach (Slot slot in slots)
        {
            if (slot.type == typeToAdd && slot.CanAddItem())
            {
                slot.AddItem(typeToAdd);
                return;
            }
        }

        foreach (Slot slot in slots)
        {
            if (slot.type == CollectableType.NONE)
            {
                slot.AddItem(typeToAdd);
                return;
            }
        }
    }
}
