using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterNextArea : MonoBehaviour
{
    bool canTeleport = false;
    string tpName = "";

    public GameObject tp1;
    public GameObject tp2;
    public GameObject tp3;
    public GameObject tp4;

    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canTeleport)
        {
            StartCoroutine(ChangeArea());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleporter"))
        {
            canTeleport = true;
            tpName = other.name;
        }
    }
    IEnumerator ChangeArea()
    {
        yield return new WaitForSeconds(.25f);
        switch (tpName)
        {
            case "tp_01":
                transform.position = tp2.transform.position + new Vector3(0, 1, 0);
                break;
            case "tp_02":
                transform.position = tp1.transform.position + new Vector3(0, 1, 0);
                break;
            case "tp_03":
                transform.position = tp4.transform.position + new Vector3(0, 1, 0);
                break;
            case "tp_04":
                transform.position = tp3.transform.position + new Vector3(0, 1, 0);
                break;
            default:
                break;
        }

    }
}
