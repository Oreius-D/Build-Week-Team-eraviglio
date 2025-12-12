using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class TestPlayerHealth : MonoBehaviour
{
    [SerializeField] int _damage;
    // Start is called before the first frame update

    public int Damage { get => _damage; set => _damage = value; }
    void OnTriggerEnter2D(Collider2D other)
    {
        var LifeController = other.GetComponent<LifeController>();
        if (LifeController)
        {
            LifeController.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
}



