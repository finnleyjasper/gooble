using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CombatObject
{
    public Attack weakness;

    // Update is called once per frame
    void Update()
    {

    }

    public override void Setup()
    {
        base.Setup();

       // trying to find an object by the name "Regular Gooble" and assign that as the enemy's weakness
       // Attack regularGooble = GameObject.Find("Regular Gooble");
       // weakness = regularGooble.GetComponent<Attack>();
    }
}
