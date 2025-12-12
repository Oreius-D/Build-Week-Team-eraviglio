using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    [SerializeField] private int maxSlots = 6;

    private List<AutoWeapon> activeWeapons = new();
    private AutoWeapon[] allWeapons;

    public IReadOnlyList<AutoWeapon> ActiveWeapons => activeWeapons;

    private void Awake()
    {
        // tutte le armi disponibili (componenti) sul player
        allWeapons = GetComponents<AutoWeapon>();

        // inizializza la lista con quelle già abilitate (es. arma base)
        for (int i = 0; i < allWeapons.Length; i++)
        {
            if (allWeapons[i].enabled)
                activeWeapons.Add(allWeapons[i]);
        }
    }

    public bool TryActivateWeapon<T>() where T : AutoWeapon
    {
        if (activeWeapons.Count >= maxSlots) return false;

        // trova l'arma di tipo T tra i componenti sul player
        for (int i = 0; i < allWeapons.Length; i++)
        {
            if (allWeapons[i] is T w)
            {
                if (activeWeapons.Contains(w)) return false; // già attiva
                w.enabled = true;
                activeWeapons.Add(w);
                return true;
            }
        }

        return false; // non presente sul player
    }

    public bool HasWeapon<T>() where T : AutoWeapon
    {
        for (int i = 0; i < activeWeapons.Count; i++)
            if (activeWeapons[i] is T) return true;
        return false;
    }
}
