using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public interface IMove
    {
        float Force { get; }
        void Move(float deltaTime, Rigidbody rigidbody, float x, float y);
    }
}

