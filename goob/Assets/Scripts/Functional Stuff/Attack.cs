using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public CombatObject user;
    public int damage;
    [SerializeField] private float duration;
    [SerializeField] private float coolDown;
    private float lastActivated;

    public Collider2D aoeCollider;
    public SpriteRenderer spriteRenderer;

    // public AudioSource?? soundFX;
    // public Animation?? animation;

    private void Awake()
    {
        aoeCollider =  GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        user = GameObject.Find("Player").GetComponent<CombatObject>();

        DeactivateAttack();
    }

    void Update()
    {
        Vector3 offset = new Vector3 (0,1,0);
        transform.position = user.transform.position + offset;
    }

    public void ActivateAttack()
    {
        if (CanAttack())
        {
            StartCoroutine(EndAttackCountDown());
            lastActivated = Time.time;

            aoeCollider.enabled = true;
            spriteRenderer.enabled = true;

            // play animation
            // play sound

        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider != user.coll2D) // if the collision is not the users' attack against its own collider
        {
            GameManager gm = FindAnyObjectByType<GameManager>();
            CombatObject victim = collider.gameObject.GetComponent<CombatObject>();

            gm.CombatObjectIsHit(user, victim);
        }
    }

    private void DeactivateAttack()
    {
        aoeCollider.enabled = false;
        spriteRenderer.enabled = false;

    }

    private bool CanAttack()
    {
        // i havent checked this properly in my head this could be wrong maths
        // just slammed something in here so compiler wouldnt yell at me
        // this code setup means there's a delay when you start the game before you can make your first attack
        if (Time.time - lastActivated + duration > coolDown)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    IEnumerator EndAttackCountDown()
    {
        yield return new WaitForSeconds(duration);
        DeactivateAttack();
    }
}
