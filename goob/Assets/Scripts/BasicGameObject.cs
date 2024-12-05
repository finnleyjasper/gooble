/*
An abstract script for almost all objects to inherit. Includes mostly sprite rendering info.

Last edited: 4/12
By: Finn
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGameObject : MonoBehaviour
{
    public Vector3 startingPosition = new Vector3 (0,0,0);
    public Transform position;
    public SpriteRenderer spriteRenderer;
    public Collider2D coll2D;
    public Rigidbody2D rb2D;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        coll2D = GetComponent<Collider2D>();
        rb2D = GetComponent<Rigidbody2D>();

        // should Start() call Setup()?
        Setup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // to setup the object after being loaded in - can add other stuff later
    // virtual to be overridden and expanded upon in child classes
    public virtual void Setup()
    {
        spriteRenderer.enabled = true;
        coll2D.enabled = true;
    }


}
