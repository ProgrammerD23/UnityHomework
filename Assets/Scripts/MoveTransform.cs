using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Transform _transform;
        private Rigidbody rigidbody;
        public float Force { get; protected set; }
        public MoveTransform(Transform transform, float force)
        {
            _transform = transform;
            Force = force;
        }
        public void Move(float deltaTime, Rigidbody rigidbody, float x, float y)
        {
            var force = deltaTime * Force;

            rigidbody.AddForce(new Vector2(x, y) * force);

        }
    }

}
