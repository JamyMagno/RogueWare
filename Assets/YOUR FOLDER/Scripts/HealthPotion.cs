using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public float heal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (other.GetComponent<Health>())
        {
            other.gameObject.GetComponent<Health>().Heal(heal);
        }
        Destroy(gameObject);
    }
}
