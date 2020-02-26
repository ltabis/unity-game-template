using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    public  Camera     playerCamera;
    private Transform  cameraTransform;

    private float yaw = .0f;
    private float pitch = .0f;

    private Vector2 _mouseSensibility = new Vector2(1, -1);

    void Start()
    {
        _velocity = 5;

        cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        ComputeMovementControls(x, y);
        ComputeCameraControls();
    }

    // Moving the player along the x y axis.
    void ComputeMovementControls(float x, float y)
    {
        if (x != 0 || y != 0)
        {
            transform.position += new Vector3(x * _velocity * Time.deltaTime, 0, y * _velocity * Time.deltaTime);
        }
    }

    // Rotate the camera of the player.
    void ComputeCameraControls()
    {
        yaw += _mouseSensibility.x * Input.GetAxis("Mouse X");
        pitch += _mouseSensibility.y * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, .0f);
    }
}
