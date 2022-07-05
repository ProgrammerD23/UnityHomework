using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private float _hp;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
