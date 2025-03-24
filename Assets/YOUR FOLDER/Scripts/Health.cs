using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public float health;

    public void Heal(float numToHeal)
    {
        if (health + numToHeal >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health += numToHeal;
        }
    }

    public void Damage(float numToDamage)
    {
        if (health - numToDamage <= 0)
        {
            Die();
        }
        else
        {
            health -= numToDamage;
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    
}
