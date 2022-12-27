using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Input.anyKey){
            return;
        }
        
        string input = Input.inputString;
        switch(input){
            case "w":
                rigidbody.velocity = Vector3.forward * 3;
                break;
            case "s":
                rigidbody.velocity = Vector3.back * 3;
                break;
            case "a":
                rigidbody.velocity = Vector3.left * 3;
                break;
            case "d":
                rigidbody.velocity = Vector3.right * 3;
                break;
            default:
                break;
        }
    }
}
