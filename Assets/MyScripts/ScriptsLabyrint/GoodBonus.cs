using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public sealed class GoodBonus : Bonus, IExecute, IFly
    {
        private float lengthFly;

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

        }

        public override void Update()
        {

        }
    }
}