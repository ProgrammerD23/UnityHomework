using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
            }
        }

        protected abstract void Interaction();
        public abstract void Update();
    }
}