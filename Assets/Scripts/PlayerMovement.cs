using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
        rb.AddForce(Vector3.ClampMagnitude(Vector3.left * horizontalInput, 0.5f) );
    }
}
