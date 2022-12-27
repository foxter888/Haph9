using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairMe : MonoBehaviour
{
    float repairPercentage;
    public static float rPercent;
    [SerializeField]
    bool canRepair;

    public Image loadingBar;


    private void Awake()
    {
        repairPercentage = 100;
    }
    private void Update()
    {
        rPercent = repairPercentage;

        if (repairPercentage <= 0)
        {
            canRepair = false;
            loadingBar.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
        if (canRepair && Input.GetKey(KeyCode.E))
        {
            loadingBar.gameObject.SetActive(true);
            repairPercentage -= .02f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canRepair = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        loadingBar.gameObject.SetActive(false);
        if (other.gameObject.CompareTag("Player"))
        {
            canRepair = false;
        }
    }
    public float GetPercentage()
    {
        return rPercent;
    }

}
