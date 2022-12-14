using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.Tilemaps.Tilemap;

public class PlayerController : Input_PlayerMovement
{
    float xRotation = 0f;
    float hInput;
    float vInput;
    float normalHeight;
    [SerializeField]
    float visibility;
    bool inDark;

    Vector3 moveDirection;

    Rigidbody rb;

    public Vector2 turn;
    public float sensitivity = 50;
    public Vector3 deltaMove;
    public float speed = 5;
    public CapsuleCollider playerCol;
    public Vector3 offset;

    public GameObject playerCam;
    public Transform orientation;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
        normalHeight = 2.25f;
        visibility = 100;
    }
    void Update()
    {
        MyInput();

        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -40f, 15f);
        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);

        if (Input.GetKeyDown(KeyCode.C))
        {
            playerCol.height = normalHeight - .5f;
            playerCam.transform.position = playerCam.transform.position - offset;
            visibility -= 25;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            playerCol.height = normalHeight;
            playerCam.transform.position = playerCam.transform.position + offset;
            visibility += 25;
        }
    }
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MyInput()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");
    }
    void MovePlayer()
    {
        moveDirection = orientation.forward * vInput + orientation.right * hInput;
        rb.AddForce(10f * speed * moveDirection.normalized, ForceMode.Force);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Darkness"))
        {
            inDark = true;
            visibility -= 50;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Darkness"))
        {
            inDark = false;
            visibility += 50;
        }
    }

}
