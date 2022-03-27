using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int damage;
   /* public LayerMask mask;
    public Transform _player;

    private void FixedUpdate()
    {
        RaycastHit hit;

        var startPosition = transform.position;
        var dist = _player.position - startPosition;

        var rayCast = Physics.Raycast(startPosition, dist, out hit, Mathf.Infinity, mask);

        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                Color color = Color.green;
                Debug.DrawRay(startPosition, dist, color);
            }
        }

       
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<Enemy>();
            enemy.Hurt(damage);
            Destroy(gameObject);
        }
    }
}
