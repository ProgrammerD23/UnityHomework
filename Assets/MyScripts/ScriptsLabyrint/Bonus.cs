using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool isInteractable;
        SaveData bonusData = new SaveData();
        private ISave data;

        public bool IsInteractable
        {
            get { return isInteractable; }
            private set
            {
                isInteractable = value;
                GetComponent<Renderer>().enabled = value;
                GetComponent<Collider>().enabled = value;
            }
        }

        void Start()
        {
            IsInteractable = true;
            bonusData.Position = transform.position;
            data = new JSonData();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
                IsInteractable = false;

                data.Save(bonusData);
            }
        }

        protected abstract void Interaction();
        public abstract void Update();
    }
}