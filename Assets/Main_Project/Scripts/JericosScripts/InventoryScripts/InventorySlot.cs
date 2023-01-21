using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

[System.Serializable]

public class InventorySlot
{
    [SerializeField] private InventoryItems itemData;
    [SerializeField] private int stackSize;

    public InventoryItems ItemData => itemData;
    public int StackSize => stackSize;

    public InventorySlot(InventoryItems source, int amount)
    {
        itemData = source;
        stackSize = amount;
    }

    public InventorySlot()
    {
        ClearSlot();
    }

    public void UpdateInventorySlot(InventoryItems data, int amount)
    {
        itemData = data;
        stackSize = amount;
    }
    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }
    public void AssignItem()
    {
        
    }
    public bool RoomLeftInStack(int amountToAdd, out int amountRemaining)
    {
        amountRemaining = itemData.MaxStackSize - stackSize;

        return RoomLeftInStack(amountToAdd);
    }
    public bool RoomLeftInStack(int amountToAdd)
    {
        if (stackSize + amountToAdd <= itemData.MaxStackSize) return true;
        else return false;
    }
    public void AddToStack(int amount)
    {
        stackSize += amount;
    }
    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }
}
