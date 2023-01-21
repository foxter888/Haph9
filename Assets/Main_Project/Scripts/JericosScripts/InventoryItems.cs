using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class InventoryItems : ScriptableObject
{
    public static InventoryItems inventoryItems;

    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
    public int MaxStackSize;
}
