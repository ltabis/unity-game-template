using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float yaw = .0f;
    private float pitch = .0f;

    public Vector2 mouseSensibility = new Vector2(1, -1);
    public Vector2 maxRotation = new Vector2(-60.0f, 90.0f);

    // Update is called once per frame
    void Update()
    {
        ComputeCameraControls();
    }

    // Rotate the camera with mouse input.
    void ComputeCameraControls()
    {
        yaw += mouseSensibility.x * Input.GetAxis("Mouse X");
        pitch += mouseSensibility.y * Input.GetAxis("Mouse Y");

        // Clamping y rotation value to prevent looping.
        pitch = Mathf.Clamp(pitch, maxRotation.x, maxRotation.y);

        // Updating the rotation of the curren object.
        transform.eulerAngles = new Vector3(pitch, yaw, .0f);
    }
}
