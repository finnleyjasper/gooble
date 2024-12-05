using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombatObject : BasicGameObject
{
    public MovementController movementController;

    [SerializeField] private int maxHealth;
    private int currentHealth;
    private bool isAlive;

    //IMPLEMENT LATER

        // the string will be a readable (internal) name of the audioclip ie. "deadthFX"
        // AudioClip may need to change to AudioSource I can't remember how Unity works
    //public Dictionary<string, AudioClip> soundEffects;

    public Attack attack;

    // public Animation animation;

    private void Awake()
    {
        movementController.comObj = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public void Setup()
    {
        // do i need to also call base.Setup() here to do those things as well? problem for later
        currentHealth = maxHealth;
    }

    public void Attack()
    {
        //attack.activateAttack();
        // attack stuff
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
}
