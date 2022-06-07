using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Maze
{
    public sealed class GoodBonus : Bonus, IExecute, IFly
    {
        private float lengthFly;
        private int Point;

        public event Action<int> AddPoints = delegate (int point) { };

        void Awake()
        {
            lengthFly = Random.Range(1f, 5f);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, lengthFly), transform.position.z);
        }

        protected override void Interaction()
        {
            AddPoints.Invoke(Point);
        }

        public override void Update()
        {
            Fly();
        }
    }
}