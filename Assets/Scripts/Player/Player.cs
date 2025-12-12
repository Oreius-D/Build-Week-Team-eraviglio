using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Creature
{
    protected override void Die()
    {
        // Jam: disabilita movimento e input, oppure respawn
        Debug.Log("PLAYER DIED");
        gameObject.SetActive(false);
    }
}
