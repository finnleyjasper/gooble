using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }

    public void CombatObjectIsHit(CombatObject attacker, CombatObject victim)
    {
        Debug.Log(attacker.name + " attacked " + victim.name);
        victim.decreaseHealth(attacker.attack.damage);
    }
}
