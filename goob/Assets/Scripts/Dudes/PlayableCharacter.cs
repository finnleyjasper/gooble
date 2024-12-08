using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacter : CombatObject
{
    public override void Setup()
    {
        base.Setup();
        SetAttack(null);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.ActivateAttack();
        }
    }

    // different from setup... to implement later
    public void Respawn()
    {
        Setup(); // collider and sprite enabled == true

        // probably need to add stuff like respawning in a certain pos or preserving other info... idk

    }

    public void SetAttack(Attack newAttack)
    {
        attack = newAttack;

        if (attack == null)
        {
            GameObject basicGooble = GameObject.Find("Basic Gooble");
            attack = basicGooble.GetComponent<Attack>();
        }
    }
}
