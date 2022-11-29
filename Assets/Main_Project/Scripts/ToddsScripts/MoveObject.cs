using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Input.anyKeyDown){
            return;
        }
        string input = Input.inputString;
        switch(input){
            case "w":
                rigidbody.velocity = Vector3.forward * 25;
                break;
            case "s":
                rigidbody.velocity = Vector3.back * 25;
                break;
            case "a":
                rigidbody.velocity = Vector3.left * 25;
                break;
            case "d":
                rigidbody.velocity = Vector3.right * 25;
                break;
            case "space":
                rigidbody.AddForce(Vector3.up * 150);
                break;
            default:
                break;
        }
    }
}
