using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script

public class CameraMovement : MonoBehaviour
{
    public Transform cam;
    public float speed;
    private Rigidbody rb;
    public float minXValue;
    public float maxXValue;
    public float minZValue;
    public float maxZValue;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        //moves camera with force
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = cam.TransformDirection(movement);
        movement.y = 0f;
        rb.AddForce(movement * speed);

        //checks if camera is in bounds
        if (transform.position.x < minXValue)
        {
            Debug.Log("camera x to low");
            transform.position = new Vector3(minXValue, transform.position.y, transform.position.z);
        }
        if (transform.position.x > maxXValue)
        {
            Debug.Log("camera x to high");
            transform.position = new Vector3(maxXValue, transform.position.y, transform.position.z);
        }
        if (transform.position.z < minZValue)
        {
            Debug.Log("camera z to low");
            transform.position = new Vector3(transform.position.x, transform.position.y, minZValue);
        }
        if (transform.position.z > maxZValue)
        {
            Debug.Log("camera z to high");
            transform.position = new Vector3(transform.position.x, transform.position.y, maxZValue);
        }
    }
}
