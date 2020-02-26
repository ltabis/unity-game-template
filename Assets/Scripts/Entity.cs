using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    protected float _velocity  = 1;
    protected float _health    = 1;

    // Get the velocity of the entity.
    public float GetVelocity()
    {
        return _velocity;
    }

    // Get the health of the entity.
    public float GetHealth()
    {
        return _health;
    }
}
