using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public float mouseSpeedX = 5.0f;
    public Transform ChaseableObject;
    private Vector3 previous; 
    // Start is called before the first frame update
    void Start()
    {
        previous = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = ChaseableObject.position - previous;
        transform.position += Vector3.right * delta.x;
        transform.position += Vector3.forward * delta.z;
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(mouseX * Vector3.up * mouseSpeedX);
        
        /*
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Rotate(Vector3.left);
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Rotate(Vector3.right);
        }
        */
        previous = ChaseableObject.position;
    }
}
