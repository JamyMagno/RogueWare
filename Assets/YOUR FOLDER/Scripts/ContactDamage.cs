using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamage : MonoBehaviour

{
    public float damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (other.GetComponent<Health>())
        {
            other.gameObject.GetComponent<Health>().Damage(damage);
        }
    }
}
