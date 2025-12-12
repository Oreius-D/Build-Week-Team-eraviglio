using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{

    [Header("Stats")]
    [SerializeField] protected int maxHealth;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float baseDamage;

    protected int currentHealth;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public float MoveSpeed => moveSpeed;
    public float BaseDamage => baseDamage;

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        if(damage <= 0) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    public virtual void Heal(int amount)
    {
        if (amount <= 0) return;
        currentHealth += amount;
        if (currentHealth > maxHealth) currentHealth = maxHealth;
    }

    protected abstract void Die();
}
