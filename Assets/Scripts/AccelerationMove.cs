using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class AccelerationMove : MoveTransform
    {
        private readonly float _acceleration;
        public AccelerationMove(Transform transform, float speed, float acceleration)
        : base(transform, speed)
        {
            _acceleration = acceleration;
        }
        public void AddAcceleration()
        {
            Force += _acceleration;
        }
        public void RemoveAcceleration()
        {
            Force -= _acceleration;
        }
    }
}
