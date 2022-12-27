using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public InventorySlot AssignedInventorySlot;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            AssignedInventorySlot.AssignItem();
        }
    }
}
