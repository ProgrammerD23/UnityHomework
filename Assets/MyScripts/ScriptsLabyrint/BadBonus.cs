using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Maze
{
    public sealed class BadBonus : Bonus, IExecute, IFly, IRotation
    {
        private float lengthFly;
        private float speedRotation;

        public event Action<string> OnCaughtPlayer= delegate (string str) {};

        private void Awake()
        {
            lengthFly = Random.Range(1f, 6f);
            speedRotation = Random.Range(15f, 60f);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, lengthFly), transform.position.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }

        protected override void Interaction()
        {
            OnCaughtPlayer.Invoke(gameObject.name);
        }

        public override void Update()
        {
            Fly();
            Rotation();
        }
    }
}