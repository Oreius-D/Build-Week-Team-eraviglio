using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaser : Enemy
{
    private Rigidbody2D rb;
    private bool hasDealtDamage = false;

    protected override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.Log($"{gameObject.name} : Manca Rigidbody2D!");
        }
    }

    protected override void MovementBehavior()
    {
        if (player == null)
        {
            if (rb != null)
                rb.velocity = Vector2.zero;
            return;
        }

        if (IsPlayerDetected(detectionRange))
        {
            ChasePlayer();
        }
        else
        {
            // Player troppo lontano, fermati
            if (rb != null)
                rb.velocity = Vector2.zero;
        }
    }
    private void ChasePlayer()
    {
        /*Vector2 direction = (player.position - transform.position).normalized;
        Vector2 */
    }

   
}
