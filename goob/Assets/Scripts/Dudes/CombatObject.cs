using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombatObject : BasicGameObject
{
    public MovementController movementController;

    [SerializeField] private int maxHealth;
    private int currentHealth;

    public Attack attack;

    //IMPLEMENT LATER

        // the string will be a readable (internal) name of the audioclip ie. "deadthFX"
        // AudioClip may need to change to AudioSource I can't remember how Unity works
    //public Dictionary<string, AudioClip> soundEffects;

    // public Animation animation;

    private void Awake()
    {
        movementController.comObj = this;
    }

    // Update is called once per frame
    void Update()
    {
        // if key pressed, do attack here
    }

    override public void Setup()
    {
        // do i need to also call base.Setup() here to do those things as well? problem for later
        currentHealth = maxHealth;
    }

    // virtual because i think enemies will need to override
        // enemies will need to be destoried upon death?
    virtual public void Die()
    {
        spriteRenderer.enabled = false;
        coll2D.enabled = false;
    }

    public void increaseHealth(int healthToAdd)
    {
        if ( (currentHealth + healthToAdd) < maxHealth)
        {
            currentHealth += healthToAdd;
        }
        else
        {
            currentHealth = maxHealth;
        }

        // play spx?
        // play animation?

    }

    public void decreaseHealth(int healthToRemove)
    {
        if ( (currentHealth - healthToRemove) <= 0)
        {
            Die();
        }
        else
        {
            currentHealth -= healthToRemove;
        }

        // play spx?
        // play animation?
    }

    // keep in mind this doesn't take into account if the gameobject is enabled or active or whatever
    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
