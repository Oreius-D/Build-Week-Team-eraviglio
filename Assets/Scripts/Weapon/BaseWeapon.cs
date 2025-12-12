using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : Weapon
{
    float bulletSpeed;
    float nextFireTime;
    [SerializeField] Bullet bulletPrefab;
    public BaseWeapon (string name, float baseDamage, float rateOfFire) : base (name, baseDamage, rateOfFire)
    {
        this.name = "Gun";
        this.BaseDamage = 5f;
        this.RateOfFire = 5f;
        ShootNearestEnemy();
    }

    GameObject FindNearestEnemy()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        Vector2 player = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        GameObject NearestEnemy = enemys[0];
        float distance;
        float min = float.MaxValue;

        foreach (GameObject enemy in enemys)
        {
            float enemyX = enemy.transform.position.x;
            float enemyY = enemy.transform.position.y;

            Vector2 enemyVec = new Vector2 (enemyY, enemyX);
            distance = Vector2.Distance (enemyVec, player);

            if (distance<min)
            {
                NearestEnemy=enemy;
                min = distance;
            }
        }
        return NearestEnemy;
    }
    void ShootNearestEnemy()
    {
        if (Time.time < nextFireTime)
            return;

        GameObject target = FindNearestEnemy();
        if (target == null)
            return;

        nextFireTime = Time.time + 1f / RateOfFire;

        Vector2 myPos = transform.position;
        Vector2 targetPos = target.transform.position;
        Vector2 dir = (targetPos - myPos).normalized;

        Vector2 spawnPos = myPos + dir * 0.3f;

        Bullet b = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
        b.Init(dir, bulletSpeed);
    }
}

