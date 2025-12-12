using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // Assicura che il GameObject abbia un Rigidbody2D
public class TopDownMovement : MonoBehaviour //Cambiato nome per farlo più generico (potrebbe essere usato anche per NPC)
{
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Creature creature;
    //private float _speed = 5f; // Commentato perché messo in Creature

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        creature = GetComponent<Creature>();
    }

    public void SetMoveInput(Vector2 input)
    {
        moveInput = input.normalized;
    }

    void FixedUpdate()
    {
        // Lo facciamo muovre, separando input e movimento
        float speed = creature != null ? creature.MoveSpeed : 5f;
        Vector2 newPos = rb.position + moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPos);

        //Non serve più, ora usiamo SetMoveInput per separare input e movimento
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        //Vector2 dir = new Vector2(h, v);

        //float sqrtLength = dir.sqrMagnitude;
        //if (sqrtLength > 1)
        //{
        //    dir = dir / Mathf.Sqrt(sqrtLength);
        //}

        //_rb.MovePosition (_rb.position + dir * (_speed * Time.deltaTime));
    }
}