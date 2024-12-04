/*
A generalised script for controlling the movement of a gameobject. Does not include input management by default.

Movement is set to 0 my default and will need to be changed by a child script or something...

...maybe this class should be abstract? In the future?

Last edited: 4/12
By: Finn
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed = 5f;

    public Vector2 movement = new Vector2 (0,0);
    public GameObject gameObject;

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        gameObject.rigidbody2D.MovePosition(gameObject.rigidbody2D.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
