/*
An abstract script for almost all objects to inherit. Includes mostly sprite rendering info.

Last edited: 4/12
By: Finn
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public Vector3 startingPosition;
    public Transform position;
    public SpriteRenderer spriteRenderer;
    public Collider2D collider2D;
    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
