using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creatura : MonoBehaviour
{
    [SerializeField] protected float maxHP = 100f;
    [SerializeField] protected float currentHP;
    [SerializeField] protected float damage = 10f;

    protected virtual void Awake () 
    {
        currentHP = maxHP;
    }

    public abstract void Attack(Creatura Target);
        
    public virtual void Takedamage (float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            currentHP = 0;
            Debug.Log($"{gameObject} e` morto!");
            Destroy(gameObject);
        }
    }
    
    public void SetHP(float value) => currentHP = value;
    public void SetDamage(float value) => damage = value;
    public float GetHealth() => currentHP;
    public float GetMaxHeath() => maxHP;
    public float GetDamage() => damage;
    public bool IsAlive() => currentHP > 0;
}
