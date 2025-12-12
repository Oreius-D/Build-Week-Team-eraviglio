using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : Enemy
{
    private bool playerDetected = false;
    private Rigidbody2D rb;

    protected override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();
    }
    protected override void MovementBehavior()
    {
        if (player == null)
        {
            if (rb != null)
                rb.velocity = Vector2.zero;
            playerDetected = false;
            return;
        }
        if (IsPlayerDetected(detectionRange))
        {
            if (!playerDetected)
            {
                Debug.Log($"{gameObject.name} vede il Player!");
                playerDetected = true;
            }
            if (IsPlayerDetected(attackRange))
            {
                Creatura playerCreature = player.GetComponent<Creatura>();
                if (playerCreature != null)
                {
                    Attack(playerCreature);
                }
            }
        }
    }
}
