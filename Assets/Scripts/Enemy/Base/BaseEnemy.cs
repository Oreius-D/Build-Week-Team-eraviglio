using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : Creature
{
    [Header("Enemy Settings")]
    [SerializeField] protected int damage;
    [SerializeField] protected float aggroRange;

    protected virtual void Update()
    {
        Think();
    }

    protected abstract void Think();
}
