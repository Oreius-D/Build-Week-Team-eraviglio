using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] int _hp;

    private void SetHp(int hp)
    {
        _hp = Mathf.Max(0, hp);

        if (_hp == 0)
        {
            Debug.Log(" Sei stato ucciso ");
            Destroy(gameObject); // to do : aggiungere animazione morte
        }
        Debug.Log(" Hp attuali : " + _hp); //to do : aggiungere animazione danno subito
    }
    public void TakeDamage(int damage) => SetHp(_hp - damage);
    public void TakeHeal(int amount) => SetHp(_hp + amount);
}
