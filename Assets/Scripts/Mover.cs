using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rb;

    public float dragForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        float deltaTime = Time.fixedDeltaTime;
        Vector3 forceDirection = Vector3.zero;
        if (Input.GetKey("w"))
        {
            forceDirection += Vector3.forward;
        }
        if (Input.GetKey("s"))
        {
            forceDirection += Vector3.back;
        }
        if (Input.GetKey("a"))
        {
            forceDirection += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            forceDirection += Vector3.right;
        }
        forceDirection = forceDirection.normalized;
        Debug.Log(forceDirection);

        rb.AddForce(forceDirection * dragForce * deltaTime, ForceMode.Impulse);
    }
}
