using System;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class View : MonoBehaviour
    {
        [SerializeField] public  Transform transform;
        [SerializeField] public Collider collider;
        [SerializeField] public Rigidbody rigidbody;

        public Action<Collider, int, Transform> OnLevelObjectContact { get; set; }

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            Collider LevelObject = other;

            OnLevelObjectContact?.Invoke(LevelObject, 12, LevelObject.transform);
        }

    }
}
