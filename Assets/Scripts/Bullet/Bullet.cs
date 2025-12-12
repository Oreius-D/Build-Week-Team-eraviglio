using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed;
    private Vector2 _dir;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 2);
    }
    public float Speed { get => _speed; set => _speed = value; }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var LifeController = collision.GetComponent<LifeController>();
        if (LifeController != null)
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 2);
    }
    public void Init(Vector2 direction, float speed)
    {
        _dir = direction.normalized;
        _speed = speed;

        rb.velocity = _dir * _speed;
    }
}



