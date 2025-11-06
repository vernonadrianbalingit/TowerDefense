using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public Vector2 turn;
    public Camera[] cameras; // Array to hold the cameras
    private int currentCameraIndex;

    void Start()
    {
        // Disable all cameras except the first one (MainCamera)
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == 0);
        }
        currentCameraIndex = 0; // Start with the MainCamera
    }

    void Update()
    {
        // Check for input to switch cameras (e.g., pressing the 'C' key)
        if (Input.GetKeyDown(KeyCode.W))
        {
            SwitchCamera();
        }

        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        cameras[currentCameraIndex].transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

    public void SwitchCamera()
    {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Update the index to the next camera
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Enable the new current camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}