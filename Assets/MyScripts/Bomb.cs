using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Bomb");
            var enemy = other.GetComponent<Enemy>();
            enemy.Hurt(damage);
            Destroy(gameObject);
        }
    }
}
