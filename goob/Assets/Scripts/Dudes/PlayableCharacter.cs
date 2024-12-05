using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacter : CombatObject
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // different from setup... to implement later
    public void Respawn()
    {
        Setup(); // collider and sprite enabled == true

        // probably need to add stuff like respawning in a certain pos or preserving other info... idk

    }
}
