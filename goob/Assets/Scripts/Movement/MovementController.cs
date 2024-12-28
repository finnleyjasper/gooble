/*
A generalised script for controlling the movement of a gameobject. Does not include input management by default.

Movement is set to 0 my default and will need to be changed by a child script or something...

...maybe this class should be abstract? In the future?

Also controls "head"/direction movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Vector2 LEFT = new Vector2(-1,0);
    private Vector2 RIGHT = new Vector2(1,0);
    private Vector2 UP = new Vector2(0,1);
    private Vector2 DOWN = new Vector2(0,-1);

    public float movementSpeed = 5f;

    public Vector2 movement = new Vector2 (0,0);
    
    public CombatObject comObj;

    // Update is called once per frame
    void Awake()
    {
        comObj = GetComponent<CombatObject>();
    }

    void FixedUpdate()
    {
        comObj.rb2D.MovePosition(comObj.rb2D.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    public string ReturnDirection()
    {
        if (movement == LEFT)
        {    
            return "left";
        }
        else if (movement == RIGHT)
        {
            return "right";
        }
        else if (movement == UP)
        {
            return "up";
        }
        else if (movement == DOWN)
        {
            return "down";
        }
        else 
        {
            return "none";
        }
    }
}
