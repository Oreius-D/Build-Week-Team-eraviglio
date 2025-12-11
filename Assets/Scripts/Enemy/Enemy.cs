using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class Enemy : Creatura
{
    [SerializeField] protected float moveSpeed = 1f;    
    [SerializeField] protected float attackRange = 1f;
    [SerializeField] protected float attackCooldown = 1f;
    [SerializeField] protected float detectionRange = 1f;
    

    protected override void Awake()
    {
        base.Awake();
    }
    protected virtual void Update() 
    {
        if (!IsAlive()) return;

        MovementBehavior();
    }
    protected abstract void MovementBehavior();

    /*protected bool IsPlayerDetected(float range)
    {
        float distance = (Enemy.position - player.position).magnitude;
        if ()
    }*/

    public override void Attack(Creatura Target)
    {
        
    }

    public float GetMoveSpeed () => moveSpeed;
    public void SetMoveSpeed (float value) => moveSpeed = value;
    public float GetAttackRange () => attackRange;
    public void SetAttackRange (float value) => attackRange = value;
    public float GetAttackCooldown () => attackCooldown;
    public void SetAttackCooldown (float value) => attackCooldown = value;
}
