using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string Name;
    public float BaseDamage;
    public float RateOfFire;

    public Weapon (string name, float baseDamage, float rateOfFire)
    {
        Name = name;
        BaseDamage = baseDamage;
        RateOfFire = rateOfFire;
    }
}
