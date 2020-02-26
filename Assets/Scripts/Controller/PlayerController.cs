using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    void Start()
    {
        _velocity = 5;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        ComputeMovementControls(x, y);
    }

    // Moving the player along the x y axis.
    void ComputeMovementControls(float x, float y)
    {
        if (x != 0 || y != 0)
        {
            transform.position += new Vector3(x * _velocity * Time.deltaTime, 0, y * _velocity * Time.deltaTime);
        }
    }
}
