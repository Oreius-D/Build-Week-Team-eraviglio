using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttackController : MonoBehaviour
{
    //Mettere prima di [] nome classe base arma
    private AutoWeapon[] weapons;

    private void Awake()
    {
        //Mettere tra <> nome classe base arma
        weapons = GetComponents<AutoWeapon>();
    }

    private void Update()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i].enabled)
                weapons[i].Tick();
        }
    }
}
