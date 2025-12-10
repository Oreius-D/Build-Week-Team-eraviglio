using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 5f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);

        float sqrtLength = dir.sqrMagnitude;
        if (sqrtLength > 1)
        {
            dir = dir / Mathf.Sqrt(sqrtLength);
        }

        _rb.MovePosition (_rb.position + dir * (_speed * Time.deltaTime));
    }
}