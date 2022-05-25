using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Rigidbody rb;
        public Transform UnitTransform;

        public static float speed = 2f;
        public static int health = 100;
        public static bool isDead;

        public abstract void Move(float x, float y, float z);
    }
}