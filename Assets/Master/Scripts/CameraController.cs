using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class CameraController : MonoBehaviour
{
    //script is used to rotate camera

    //what the camera follows so that it can smoothly rotate
    public Transform objectToFollow;
    private Vector3 offset;
    //movement speeds
    private float pitch = -5;
    public float yawSpeed;
    private float yawInput = 0;

    //create offset to allow camera the ability to rotate smoothly
    void Start()
    {
        offset = transform.position - objectToFollow.transform.position;
    }
    //move and rotate camera
    void Update()
    {
        transform.position = objectToFollow.transform.position + offset;
        yawInput -= Input.GetAxis("CameraHorizontal") * yawSpeed * Time.deltaTime;
    }
    //position camera upright
    private void LateUpdate()
    {
        transform.position = objectToFollow.position - offset;
        transform.LookAt(objectToFollow.position + Vector3.up * pitch);
        transform.RotateAround(objectToFollow.position, Vector3.up, yawInput);
    }
}
