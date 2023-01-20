using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPos : MonoBehaviour
{
    public bool tpVariation = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleporter"))
        {
            tpVariation = false;
        }
        else if (other.gameObject.CompareTag("TeleporterEnd"))
        {
            tpVariation = true;
        }
    }
}
