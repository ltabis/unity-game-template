using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    public  Camera     playerCamera;
    private Transform  cameraTransform;

    void Start()
    {
        _velocity = 2;

        cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ComputeMovementControls();
        // ComputeCameraControls();
    }

    // Moving the player with axis controls.
    void ComputeMovementControls()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0 || y != 0)
        {
            transform.position += new Vector3(x * _velocity * Time.deltaTime, 0, y * _velocity * Time.deltaTime);
        }
    }

    void ComputeCameraControls()
    {
        Vector3 cameraDirection = new Vector3(cameraTransform.forward.x, 0f, cameraTransform.forward.z);
        Vector3 playerDirection = new Vector3(_velocity, 0f, _velocity);

        if (Vector3.Angle(cameraDirection, playerDirection) > 15f)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.rotation, 15f);
        }
    }
}
