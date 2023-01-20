using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterNextArea : LastPos
{
    public GameObject player;
    bool canTeleport = false;

    private Vector3[] teleporters = new Vector3[4];
    public GameObject teleporter01;
    public GameObject teleporter02;
    public GameObject teleporter03;
    public GameObject teleporter04;

    public int lastTP = 0;

    private void Start()
    {
        teleporters[0] = teleporter01.transform.position + new Vector3(0, 2f,0);
        teleporters[1] = teleporter02.transform.position + new Vector3(0, 2f, 0);
        teleporters[2] = teleporter03.transform.position + new Vector3(0, 2f, 0);
        teleporters[3] = teleporter04.transform.position + new Vector3(0, 2f, 0);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ChangeArea());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTeleport = true;
        }
    }
    IEnumerator ChangeArea()
    {



        yield return new WaitForSeconds(.25f);
        switch (lastTP)
        {
            case 0:
                player.transform.position = teleporters[1];
                lastTP = 1;
                break;
            case 1:
                if (tpVariation)
                {
                    player.transform.position = teleporters[0];
                    lastTP = 0;
                }
                else if (!tpVariation)
                {
                    player.transform.position = teleporters[3];
                    lastTP = 3;
                }
                break;
            case 2:
                player.transform.position = teleporters[1];
                break;
            case 3:
                if (tpVariation)
                {
                    player.transform.position = teleporters[1];
                    lastTP = 1;
                }
                break;
            case 4:
                player.transform.position = teleporters[0];
                break;
            default:
                break;
        }
        

    }
}
