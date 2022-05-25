using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public sealed class Player : Unit
    {
        private void Awake()
        {
            UnitTransform = transform;
            if (GetComponent<Rigidbody>())
            {
                rb = GetComponent<Rigidbody>();
            }
            health = 100;
            isDead = false;
        }
        public override void Move(float x, float y, float z)
        {
            if (rb)
            {
                rb.AddForce(new Vector3(x, y, z) * speed);
            }
            else
            {
                Debug.Log("NO RB");
            }
        }
        
    }
}