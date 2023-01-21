using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickUp : MonoBehaviour
{
    bool inRange;
    public float PickUpRadius = 1f;
    public InventoryItems ItemData;
    Collider player;

    private SphereCollider myCollider;

    private void Awake()
    {
        myCollider = GetComponent<SphereCollider>();
        myCollider.isTrigger = true;
        myCollider.radius = PickUpRadius;
    }
    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            if (player != null)
            {
                var inventory = player.transform.GetComponent<InventoryHolder>();
                if (!inventory) return;

                if (inventory.InventorySystem.AddToInventory(ItemData, 1))
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
        player = other;
    }
    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        player = null;
    }
}
