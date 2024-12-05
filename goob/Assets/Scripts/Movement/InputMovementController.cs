using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovementController : MovementController
{
    public float dodgeCoolDown = 1.5f;
    private bool dodgeRollAvailible = true;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.X) && dodgeRollAvailible)
        {
            DodgeRoll();
        }
    }

    private void DodgeRoll()
    {
        float defaultSpeed = movementSpeed;
        movementSpeed = movementSpeed * 3.5f;
        StartCoroutine(DodgeRollDuration(0.1f, defaultSpeed));

        dodgeRollAvailible = false;
        StartCoroutine(DodgeRollCoolDown(dodgeCoolDown));
    }

    IEnumerator DodgeRollDuration(float delayTime, float defaultSpeed)
    {
        yield return new WaitForSeconds(delayTime);
        movementSpeed = defaultSpeed;
    }

    IEnumerator DodgeRollCoolDown(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        dodgeRollAvailible = true;
    }
}
