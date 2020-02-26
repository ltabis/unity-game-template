using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    // Camera elements.
    public  Camera     playerCamera;
    private Transform  playerCameraTransform;

    void Start()
    {
        _velocity = 5;

        playerCameraTransform = playerCamera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ComputeMovementControls();
    }

    // Moving the player along the x y axis.
    void ComputeMovementControls()
    {
        // Move the body following the camera angle.
        transform.eulerAngles = new Vector3(.0f, playerCameraTransform.eulerAngles.y, .0f);

        if (Input.GetButton("Forward"))
        {
            transform.position += transform.forward * _velocity * Time.deltaTime;
        }
        if (Input.GetButton("Backward"))
        {
            transform.position += transform.forward * _velocity * Time.deltaTime * -1;
        }
        if (Input.GetButton("Right"))
        {
            transform.position += transform.right * _velocity * Time.deltaTime;
        }
        if (Input.GetButton("Left"))
        {
            transform.position += transform.right * _velocity * Time.deltaTime * -1;
        }
    }
}
